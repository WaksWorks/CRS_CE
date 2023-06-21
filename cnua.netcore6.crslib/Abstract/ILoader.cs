using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Abstract
{
	/// <summary>
	/// persist data to file, database , etc.
	/// </summary>
	public interface ILoader
	{
		//persist structured data
		void WriteCSV(IEnumerable<Post> posts);
		void DatabaseUpload(IEnumerable<Post> posts);
		void WriteWave(IEnumerable<Post> posts);
		/// <summary>
		/// all files formats encrypted serialiser
		/// </summary>
		/// <param name="posts"></param>
		void WriteCRSBinaryZip(IEnumerable<Post> posts);
		/// <summary>
		/// open packed files as crsbinaryzip; crsb extension
		/// </summary>
		/// <param name="posts"></param>
		IEnumerable<Post> ReadCRSBinaryZip(string filePath);
	}
}
