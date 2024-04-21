using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.PhoneForms
{
	public partial class PhoneDataForm : Form
	{
		private readonly Phone _tempPhone;
		public Phone Phone { get; }

		public PhoneDataForm(Phone phone)
		{
			InitializeComponent();
			Phone = phone;
			_tempPhone = phone.Clone();
		}

		private void FormPhoneData_Load(object sender, System.EventArgs e)
			=> phoneListBindingSource.DataSource = _tempPhone ?? phoneListBindingSource.DataSource;

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(tbNumber.Text) || string.IsNullOrEmpty(tbType.Text))
			{
				MessageBox.Show("All fields must be filled in!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Phone.CopyFrom(_tempPhone);

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void tbNumber_Leave(object sender, System.EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				string pattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
				if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, pattern))
				{
					if (textBox.Text.StartsWith("0"))
						textBox.Text = "+380" + textBox.Text.Substring(1);
					else if (!textBox.Text.StartsWith("+") && textBox.Text.StartsWith("380"))
						textBox.Text = "+" + textBox.Text;
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