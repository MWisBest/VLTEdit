using System.IO;

namespace VLTEdit
{
	public class EAGCollectionKey : EABaseType // OBF: al.cs
	{
		[DataValue( "Hash" )]
		public uint hash;
		[DataValue( "Value" )]
		public string value;

		public override void read( BinaryReader A_0 )
		{
			this.hash = A_0.ReadUInt32();
			this.value = HashTracker.getValueForHash( this.hash );
		}

		public override void write( BinaryWriter A_0 )
		{
			// TODO: This doesn't make much sense, what if we got a "0x"-based hash from HashTracker?
			// Replace with writing stored hash for now
			//A_0.Write( HashUtil.getHash32( this.value ) );
			A_0.Write( this.hash );
		}

		public override string ToString()
		{
			return this.value;
		}
	}
}
