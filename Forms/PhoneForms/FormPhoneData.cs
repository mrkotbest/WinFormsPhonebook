using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneData : Form
	{
		public Mode CurrentMode { get; }
		public Phone Phone { get; set; }

		public FormPhoneData(Mode mode, Phone phone = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			Phone = phone;

			if (CurrentMode == Mode.Edit && Phone != null)
			{
				tbNumber.Text = Phone.Number;
				tbType.Text = Phone.Type;
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (tbNumber.Text == string.Empty | tbType.Text == string.Empty)
			{
				MessageBox.Show("You need to fill in all the fields!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Phone = new Phone(tbNumber.Text, tbType.Text);

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a number
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbNumber_Validated(object sender, System.EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				if (!string.IsNullOrEmpty(tbNumber.Text))
				{
					// If the text in the TextBox starts with "0"
					if (textBox.Text.StartsWith("0"))
					{
						textBox.Text = "+380" + textBox.Text.Substring(1);
					}
					// If the text in the TextBox starts with any digit
					else if (char.IsDigit(textBox.Text[0]))
					{
						textBox.Text = "+" + textBox.Text;
					}
				}
			}
		}
		private void tbType_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}