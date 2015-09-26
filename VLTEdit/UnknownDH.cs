using System.Collections;
using System.IO;
using System.Reflection;

namespace VLTEdit
{
	[DefaultMember( "Item" )]
	public class UnknownDH : UnknownC0, IEnumerable
	{
		public UnknownAS[] asa1;

		public override void read( BinaryReader A_0 )
		{
			int num = A_0.ReadInt32();
			this.asa1 = new UnknownAS[num];
			for( int i = 0; i < num; ++i )
			{
				this.asa1[i] = new UnknownAS();
				this.asa1[i].read( A_0 );
			}
		}

		public override void write( BinaryWriter A_0 )
		{
			A_0.Write( this.asa1.Length );
			for( int i = 0; i < this.asa1.Length; ++i )
			{
				this.asa1[i].write( A_0 );
			}
		}

		public IEnumerator GetEnumerator()
		{
			return this.asa1.GetEnumerator();
		}
	}
}
