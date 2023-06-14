using Xunit;
using CSR.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Collections._Tests
{
	public class Bucket_Tests
	{
		[Fact()]
		public void Bucket_Test()
		{
			var bucket = new Bucket<string>();
			bucket.Add("test");
			Assert.True(bucket.Count == 1);
		}
	}
}