using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneData : Form
	{
		public BindingList<Phone> PhoneList { get; set; }
		public Phone CurrentPhone { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPhoneData(BindingList<Phone> phoneList, Mode mode, Phone phone = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			CurrentPhone = phone;
			PhoneList = phoneList;

			if (CurrentMode == Mode.Edit)
			{
				tbNumber.Text = CurrentPhone.Number;
				tbType.Text = CurrentPhone.Type;
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
				if (CurrentMode == Mode.Add)
				{
					PhoneList.Add(new Phone(tbNumber.Text, tbType.Text));
				}
				else if (CurrentMode == Mode.Edit)
				{
					CurrentPhone.Number = tbNumber.Text;
					CurrentPhone.Type = tbType.Text;
				}
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
	}
}