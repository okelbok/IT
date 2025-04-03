using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_IT.Services
{
	public class StreamManager
	{
		internal static int BYTE_LENGTH = 8;

		public byte[] BytesToBits(byte[] bytes)
		{
			byte[] bits = new byte[bytes.Length * BYTE_LENGTH];

			for (int i = 0; i < bytes.Length; i++)
			{
				for (int j = 0; j < BYTE_LENGTH; j++)
				{
					bits[i * BYTE_LENGTH + j] = (byte)((bytes[i] >> j) & 0x1);
				}
			}

			return bits;
		}

		public byte[] BitsToBytes(byte[] bits)
		{
			byte[] bytes = new byte[bits.Length / 8];

			for (int i = 0; i < bytes.Length; i++)
			{
				byte oneByte = 0;

				for (int j = 0; j < BYTE_LENGTH; j++)
				{
					oneByte |= (byte)(bits[i * BYTE_LENGTH + j] << j);
				}

				bytes[i] = oneByte;
			}

			return bytes;
		}

		public string BitsToString(byte[] bits)
		{
			StringBuilder bitOutput = new StringBuilder();

			for (int i = 0; i < bits.Length; i++)
			{
				bitOutput.Append((bits[i] == 0) ? '0' : '1');
				
				if (i % BYTE_LENGTH == BYTE_LENGTH - 1)
					bitOutput.Append(" ");
			}
			
			return bitOutput.ToString().Trim();
		}

	}
}
