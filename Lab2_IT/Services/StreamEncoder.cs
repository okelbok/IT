namespace Lab2_IT.Services
{
	public class StreamEncoder
	{
		public byte[] initialBits;
		public byte[] keyBits;
		public byte[] resultBits;

		public static int REGISTER_LENGTH = 40;
		public byte[] register = new byte[REGISTER_LENGTH];

		private static int[] polynomialDegrees = { 40, 21, 19, 2 };

		private byte GetFirstBit(byte[] key)
		{
			byte firstBit = 0;

			for (int i = 0; i < polynomialDegrees.Length; i++)
			{
				firstBit ^= key[key.Length - polynomialDegrees[i]];
			}

			return firstBit;
		}

		private void ShiftToLeft(byte[] key)
		{
			for (int i = 0; i < key.Length - 1; i++)
			{
				key[i] = key[i + 1];
			}
		}

		private void GenerateKey(int length)
		{
			keyBits = new byte[length];

			for (int i = 0; i < length; i++)
			{
				keyBits[i] = register[0];

				byte firstBit = GetFirstBit(register);
				ShiftToLeft(register);
				register[REGISTER_LENGTH - 1] = firstBit;
			}
		}

		public void Encode()
		{
			resultBits = new byte[initialBits.Length];

			GenerateKey(resultBits.Length);

			for (int i = 0; i < resultBits.Length; i++)
			{
				resultBits[i] = (byte)(keyBits[i] ^ initialBits[i]);
			}
		}
	}
}
