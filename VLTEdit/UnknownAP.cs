using System.IO;
using System.Text;

namespace VLTEdit
{
	public class UnknownAP
	{
		public static string a( BinaryReader A_0 )
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte b;
			while( ( b = A_0.ReadByte() ) != 0 )
			{
				stringBuilder.Append( (char)b );
			}
			return stringBuilder.ToString();
		}

		public static void a( BinaryWriter A_0, string A_1 )
		{
			byte[] bytes = Encoding.ASCII.GetBytes( A_1 );
			A_0.Write( bytes );
			A_0.Write( (byte)0 );
		}
	}
}
