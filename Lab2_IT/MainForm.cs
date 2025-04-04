using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lab2_IT.Services;

namespace Lab2_IT
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private static int BYTE_LENGTH = StreamManager.BYTE_LENGTH;
		private static int MAX_BYTE_COUNT = 40;
		internal static int REGISTER_LENGTH = StreamEncoder.REGISTER_LENGTH;

		private StreamManager utils = new StreamManager();
		private StreamEncoder encoder = new StreamEncoder();

		private string GetFirstAndLastBytes(byte[] bits)
		{
			StringBuilder bitOutput = new StringBuilder();
			byte[] firstBytes = new byte[MAX_BYTE_COUNT / 2 * BYTE_LENGTH];
			byte[] lastBytes = new byte[MAX_BYTE_COUNT / 2 * BYTE_LENGTH];

			for (int i = 0; i < firstBytes.Length; i++)
			{
				firstBytes[i] = bits[i];
				lastBytes[i] = bits[bits.Length - MAX_BYTE_COUNT / 2 * BYTE_LENGTH + i];
			}

			bitOutput.Append("Первые " + MAX_BYTE_COUNT / 2 + " байт:");
			bitOutput.Append(Environment.NewLine);
			bitOutput.Append(utils.BitsToString(firstBytes));
			bitOutput.Append(Environment.NewLine);
			bitOutput.Append("Последние " + MAX_BYTE_COUNT / 2 + " байт:");
			bitOutput.Append(Environment.NewLine);
			bitOutput.Append(utils.BitsToString(lastBytes));

			return bitOutput.ToString();
		}

		private string GetLongBitText(byte[] bits)
		{
			string result;

			if (bits.Length > MAX_BYTE_COUNT * BYTE_LENGTH)
				result = GetFirstAndLastBytes(bits);
			else
				result = utils.BitsToString(bits);

			return result;
		}

		public byte[] GetInitialState(TextBox text)
		{
			int i = 0;
			byte[] initialState = new byte[REGISTER_LENGTH];
   			string str = text.Text;

			foreach (char symbol in str)
			{
				if ((symbol.Equals('0') || symbol.Equals('1')) && i < REGISTER_LENGTH)
				{
					initialState[i] = (byte)(symbol - '0');
					i++;
				}					
			}

			if (i != REGISTER_LENGTH)
				initialState = null;
    			else
       				text.Text = utils.BitsToString(initialState);

			return initialState;
		}

		private void InitialStateTextBox_TextChanged(object sender, EventArgs e)
		{
			ClearEncodedFields();
		}

		private void InputButton_Click(object sender, EventArgs e)
		{
			if (InputDialog.ShowDialog() == DialogResult.OK)
			{
				ClearEncodedFields();

				OutputDialog.DefaultExt = Path.GetExtension(InputDialog.FileName);

				byte[] bits = utils.BytesToBits(File.ReadAllBytes(InputDialog.FileName));

				encoder.initialBits = bits;

				InitialTextBox.Text = GetLongBitText(bits);
			}
		}

		private void OutputButton_Click(object sender, EventArgs e)
		{
			if (ResultTextBox.Text.Length > 0)
			{
				if (OutputDialog.ShowDialog() == DialogResult.OK)
				{
					byte[] bytes = utils.BitsToBytes(encoder.resultBits);

					using (FileStream fileStream = new FileStream(OutputDialog.FileName, FileMode.Create))
					{
						fileStream.Write(bytes, 0, bytes.Length);
					}
				}
			}
			else
				MessageBox.Show("Полученный текст не должен быть пустым.", "Ошибка записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void EncodeButton_Click(object sender, EventArgs e)
		{
			encoder.register = GetInitialState(InitialStateTextBox);

			if (encoder.register != null)
			{
				if (InitialTextBox.Text.Length > 0)
				{
					encoder.Encode();

					KeyTextBox.Text = GetLongBitText(encoder.keyBits);
					ResultTextBox.Text = GetLongBitText(encoder.resultBits);
				}
				else
					MessageBox.Show("Исходный файл не должен быть пустым.", "Ошибка чтения", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
				MessageBox.Show("Значение ключа должно содержать не менее 40 бит (0 или 1).", "Ошибка ключа", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void ClearEncodedFields()
		{
			KeyTextBox.Clear();
			ResultTextBox.Clear();
		}

		private void ClearFieldsButton_Click(object sender, EventArgs e)
		{
			InitialStateTextBox.Clear();
			InitialTextBox.Clear();
			ClearEncodedFields();
		}
	}
}
