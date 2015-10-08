using System.IO;

namespace VLTEdit.Types
{
	public class EAUInt16 : EABaseType
	{
		[DataValue( "Value" )]
		public ushort value;

		public override void read( BinaryReader br )
		{
			this.value = br.ReadUInt16();
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
