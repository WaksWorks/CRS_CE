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
using CSR.Collections;

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

		public static bool Load(this ChatRecordSet cr, string exportFilePath)
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
			cr.ChatGroupName = f.Name.Substring(19).Replace(WHATSAPP_FILE_PREFIX, "").Replace(".txt", "");
			cr.FilePath = f.FullName;
			cr.InputText = File.ReadAllText(f.FullName);
			cr.FilteredRows = cr.InputText.Split(Environment.NewLine).GetFilteredRows();
			cr.Posts = cr.FilteredRows.Select(r => r.ToPost()).Where(p => p != null).Select(p => p!).ToList<Post>();

			cr.IsLoaded = true;

			return true;
		}

		public static Post? ToPost(this string row)
		{
			//Row Text Sample:> 23/04/2023, 21:23 - W2W3: And I'll keep you here.
			DateTime dateValue;
			string datestr = row.Substring(0, 17).Replace(",", "");
			string memberHandle = @"";
			string[] arr = row.Substring(20).Split(':');
			try
			{
				if (!DateTime.TryParse(datestr, out dateValue))
				{
					return null;
				}

				return new Post()
				{
					MemberHandle = arr[0],
					TimePosted = dateValue,
					Message = arr[1],
					PostType = memberHandle.Contains(@"@System") ? PostType.System : PostType.Member
				};
			}
			catch (Exception e)
			{
				return null;
			}
		}
		/// <summary>
		/// strategy: insert PostHeader [datetime, MemberHandle] content only lines
		/// Transform multiline content into entry only lines
		/// insert 
		/// </summary>
		/// <param name="rows"></param>
		/// <returns>array of strings</returns>
		public static IEnumerable<string> GetFilteredRows(this IEnumerable<string> rows)
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
		/// <summary>
		/// transform filtered rows into posts
		/// </summary>
		/// <param name="rows"></param>
		/// <returns></returns>
		public static IEnumerable<Post> GetPosts(this IEnumerable<string> rows)
		{
			//convert rows to posts
			List<Post> lst = new List<Post>();
			int i = 0;
			foreach (string row in rows)
			{
				Post? p = row.ToPost();
				if (p != null)
					p.PostId = i++;
				lst.Add(p);
			}
			return lst.ToArray<Post>();
		}
	}
}
