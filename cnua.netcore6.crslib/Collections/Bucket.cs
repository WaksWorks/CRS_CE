using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSR.Collections
{
	public class Bucket<T>:List<T>
	{
		public Bucket() { }
		public Bucket(IEnumerable<T> collection) : base(collection) { }
		public Bucket(int capacity) : base(capacity) { }
		public Bucket(IEnumerable<T> collection, int capacity) : base(capacity) { }

	}
}
