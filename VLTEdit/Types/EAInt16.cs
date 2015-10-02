using System.IO;

namespace VLTEdit
{
	public class EAInt16 : EABaseType
	{
		[DataValue( "Value" )]
		public short value;

		public override void read( BinaryReader br )
		{
			this.value = br.ReadInt16();
		}

		public override void write( BinaryWriter bw )
		{
			bw.Write( this.value );
		}

		public override string ToString()
		{
			return this.value.ToString();
		}
	}
}
