using System.Collections;
using System.Reflection;

namespace VLTEdit
{
	// VLTRoot?!
	[DefaultMember( "Item" )]
	public class UnknownDR : IEnumerable // OBF: dr.cs
	{
		public UnknownB0 b01;
		public UnknownC c1;
		public EABaseType[] bba1;
		public bool[] booa1;
		public VLTClass dq1;

		public void a( VLTClass A_0 )
		{
			this.dq1 = A_0;
		}

		public void a( UnknownB0 A_0 )
		{
			this.b01 = A_0;
		}

		public void a( UnknownC A_0 )
		{
			this.c1 = A_0;
		}

		public UnknownDR( int count )
		{
			this.bba1 = new EABaseType[count];
			this.booa1 = new bool[count];
		}

		public void a( int A_0, EABaseType A_1 )
		{
			this.booa1[A_0] = true;
			this.bba1[A_0] = A_1;
		}

		public IEnumerator GetEnumerator()
		{
			return this.bba1.GetEnumerator();
		}
	}
}
