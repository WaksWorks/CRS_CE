//using CSR.IO;
using CSR.System;
using CSR.Entities.Extensions;
using CSR.Entities;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Reflection;

namespace CSR.Entities.Extensions
{
	/// <summary>
	/// A backup file extracted from a WhatsApp group chat 
	/// </summary>
	public static class ChatRoom_Extension
	{

		public const string WHATSAPP_FILE_PREFIX = @"WhatsApp Chat with ";
		public const string SAMPLE_TEXT_ROW = @"17/03/2023, 20:33 - +44 7960 834220: Hahaha";
		public const string DATE_PATTERN = @"(\d*/\d*/\d*, \d*:\d*)";
		public const string MEMBERHANDLE_PATTERN = @"(\b - .*\w*):";
		public const string MAIN_PATTERN = $"(?im)^.*?(?<!\\w){DATE_PATTERN}{MEMBERHANDLE_PATTERN}(?!\\w).*";

		public static bool Load(this ChatRoom cr, string exportFilePath)
		{

			FileInfo? f = null;
			try
			{
				f = new FileInfo(exportFilePath);
				if (!f.Exists) return false;
				if (!f.Name.Contains(WHATSAPP_FILE_PREFIX)) throw new Exception("Input WhatsApp Export File name expected");
			}
			catch (Exception e)
			{
				cr.IsLoaded = false;
				return false;
			}
			cr.ChatRoomName = f.Name.Substring(19).Replace(WHATSAPP_FILE_PREFIX, "").Replace(".txt", "");
			cr.ChatRoomPath = f.FullName;
			cr.RawText = File.ReadAllText(exportFilePath);
			cr.Rows = File.ReadAllLines(exportFilePath);
			//cr.Posts = cr.Rows.ToPosts();
			return true;
		}
		public static bool IsNotSystemPost(this string row)
		{
			//TODO: contains date at start and has memberhandle
			//Row Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you  oth in the loop right here.
			//has date starting row
			DateTime dateValue;
			bool b = false;
			string datestr = row.Substring(0, 17).Replace(",", "");
			if (!DateTime.TryParse(datestr, out dateValue))
				return false;
			//has member handle
			string memberHandle = row.Replace(" ", "").Split(':')[0].Split('-')[1];
			if (memberHandle.Length > 0)
				b = true;

			return b;
		}
		/// <summary>
		/// true when the row has a Chatroom 
		///         Member Name or Phone number Identifier
		///         Date Posted means it's not a content line
		///         MessageLine pressumed therefore
		/// </summary>
		/// <param name="row"></param>
		/// <returns>True is Member Post</returns>
		public static (bool IsPost, Post? post) GetPostFrag(this string row)
		{
			//TODO: contains date at start and has memberhandle
			//Row Text Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you  oth in the loop right here.
			//System Row Sample: >> 23/04/2023, 20:53 - Wole Solanke added you
			DateTime dateValue;
			bool b = false;
			string datestr = row.Substring(0, 17).Replace(",", "");
			if (!DateTime.TryParse(datestr, out dateValue))
				return (false, null);
			//has member handle
			string[] arr = row.Substring(20).Split(':');
			string memberHandle = @"System";
			string message = row.Substring(20);
			PostType postType = PostType.System;
			if (arr.Length >= 2)
			{
				memberHandle = arr[0];
				message = arr[1];
			}

			return (true, new Post()
			{
				MemberHandle = memberHandle,
				TimePosted = dateValue,
				Message = message,
				PostType = postType
			});
		}
		[Obsolete("Do not use")]
		public static Post? ToPost(this string row)
		{
			//TODO: contains date at start and has memberhandle
			//Row Text Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you  oth in the loop right here.
			//System Row Sample: >> 23/04/2023, 20:53 - Wole Solanke added you
			DateTime dateValue;
			bool b = false;
			string datestr = row.Substring(0, 17).Replace(",", "");

			if (!DateTime.TryParse(datestr, out dateValue))
			{
				//content line should be added to previous post
				var p = new Post()
				{
					PostType = PostType.TextOnlyLine,
					Message = row
				};
			}
			//has member handle
			string memberHandle = @"System";
			string message = row.Substring(20);
			PostType postType = PostType.System;
			string[] arr = row.Substring(20).Split(':');
			if (arr.Length >= 2)
			{
				memberHandle = arr[0];
				message = arr[1];
			}
			return new Post()
			{
				MemberHandle = memberHandle,
				TimePosted = dateValue,
				Message = message,
				PostType = postType
			};
		}
		public static Post? GetPost(this string? row)
		{
			//Row Text System_Sample:> 23/04/2023, 21:18 - You started a call
			//Row Text User_Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you  oth in the loop right here.
			string systemHandle = @"System";
			string memberHandle = @"";
			string message = @"";
			PostType postType = PostType.Text;
			//>>>>>
			DateTime dateValue;
			bool b = false;
			string datestr = row.Substring(0, 17).Replace(",", "");
			bool blb = DateTime.TryParse(datestr, out dateValue);
			string[] arr = row.Split(':');
			if (arr.Length == 2)//system post is datetime and message only
			{
				memberHandle = systemHandle;
				message = row.Substring(20);
				postType = PostType.System;
			}
			else if (arr.Length > 2)
			{
				memberHandle = arr[1];
				message = arr[2];
				postType = PostType.Text;
			}
			return new Post()
			{
				MemberHandle = memberHandle,
				TimePosted = dateValue,
				Message = message,
				PostType = postType
			};
		}
		[Obsolete("Inserts Row Header into multiline text only content " +
			"Insert System label as MemberHandle in System Posts" +
			"PostType.TextOnlyLine: 23/04/2023, 23:31 - W2W3: FXN9JR" +
			"PostType.System 23/04/2023, 21:18 - @System: You started a call")]
		/// <summary>
		/// strategy: insert PostHeader [datetime, MemberHandle] content only lines
		/// Transform multiline content into entry only lines
		/// insert 
		/// </summary>
		/// <param name="rows"></param>
		/// <returns>array of strings</returns>
		public static string[] InsertRowHeaderToMultilineContent(this string[] rows)
		{
			string memberHandle = "";
			string key = "";
			string rowBuffer = "";
			List<string> lst = new List<string>();
			StringBuilder sb = new StringBuilder();

			IEnumerable<IGrouping<string, string>> query = rows
				.Where(s => s.Length > 0)
				.GroupBy(s => s.Length < 17 ? sb.Append(s).ToString() : s.Substring(0, 17)
				.ToString());

			foreach (IGrouping<string, string> grouping in query)
			{
				DateTime dtime;
				bool boo = DateTime.TryParse(grouping.Key, out dtime);
				if (boo)
				{
					sb.Clear();
					foreach (string groupname in grouping)
					{   /* insert system as memberHandle into system Posts */
						if (groupname.Split(':').Length == 2)
						{
							memberHandle = @" @System: ";
							rowBuffer = groupname.Insert(20, memberHandle);
							lst.Add(rowBuffer);
						}
						else
							lst.Add(groupname);
						//preserve for multiline header insert
						key = grouping.Key;
						var arr = groupname.Substring(20).Split(':');
						memberHandle = arr[0];
					}
				}
				else
				{
					/* basically insert the RowHeader into the content line of multiline post type */
					sb.Append(key);
					sb.Append(" - ");
					sb.Append(memberHandle);
					sb.Append(@": ");
					sb.Append(grouping.ElementAt(0));
					lst.Add(sb.ToString());
					sb.Clear();
				}
			}
			return lst.ToArray<string>();
		}
		[Obsolete(@"Not for use on unfiltered Rows straight from the WhatsApp Export file")]
		public static Post? ToPost2(this string row)
		{
			//TODO: contains date at start and has memberhandle
			//Row Text Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you  oth in the loop right here.

			DateTime dateValue;
			bool b = false;
			string datestr = row.Substring(0, 17).Replace(",", "");

			if (!DateTime.TryParse(datestr, out dateValue))
			{
				//content line should be added to previous post
				var p = new Post()
				{
					PostType = PostType.TextOnlyLine,
					Message = row
				};
			}
			//has member handle
			string memberHandle = @"System";
			string message = row.Substring(20);
			PostType postType = PostType.System;
			string[] arr = row.Substring(20).Split(':');
			if (arr.Length >= 2)
			{
				memberHandle = arr[0];
				message = arr[1];
			}
			return new Post()
			{
				MemberHandle = memberHandle,
				TimePosted = dateValue,
				Message = message,
				PostType = postType
			};
		}
		public static bool IsDate(this string row)
		{
			DateTime dateValue;
			try
			{
				string str = row.Substring(0, 17).Replace(",", "");
				return DateTime.TryParse(str, out dateValue);
			}
			catch (ArgumentOutOfRangeException aoor)
			{
				return false;
			}
		}
		public static DateTime ToDate(this string row)
		{
			DateTime dateValue;

			string str = row.Substring(0, 17).Replace(",", "");
			if (DateTime.TryParse(str, out dateValue))
				return dateValue;
			else
				return DateTime.MinValue;
		}
		public static void WriteRowsCSV(this ChatRoom? cr)
		{
			if (cr.IsLoaded)
			{
				using (StreamWriter? writer = new StreamWriter(cr.ChatRoomPath))
				using (CsvWriter? csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
				{
					csv.WriteRecords(cr.Rows);
				}
			}
		}

	}
}
