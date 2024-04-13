using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneData : Form
	{
		public Phone Phone { get; }

		public FormPhoneData(Phone phone)
		{
			InitializeComponent();
			Phone = phone;
		}

		private void FormPhoneData_Load(object sender, System.EventArgs e)
			=> phoneListBindingSource.DataSource = Phone ?? phoneListBindingSource.DataSource;

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(tbNumber.Text) || string.IsNullOrEmpty(tbType.Text))
			{
				MessageBox.Show("You need to fill in all the fields!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-') // Checking if a symbol is a number or a symbol "+" or a symbol "-".
				e.Handled = true;
		}
		private void tbNumber_Validated(object sender, System.EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				if (!string.IsNullOrEmpty(tbNumber.Text))
				{
					if (textBox.Text.StartsWith("0"))   // If the text in the TextBox starts with "0".
						textBox.Text = "+380" + textBox.Text.Substring(1);
					else if (textBox.Text.StartsWith("3") || textBox.Text.StartsWith("38") || textBox.Text.StartsWith("380"))   // If the text in the TextBox starts with "3" or "38" or "380".
						textBox.Text = "+" + textBox.Text.Substring(1);
				}
			}
		}
		private void tbType_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}