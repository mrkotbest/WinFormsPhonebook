using System.Drawing;
using System.Windows.Forms;

namespace WF_Phonebook.Forms.EmailForms
{
	public partial class EmailForm : Form
	{
		private const string _emailPattern = @"^[-a-z0-9!#$%&'*+/=?^_`{|}~]+(\.[-a-z0-9!#$%&'*+/=?^_`{|}~]+)*@([a-z0-9]([-a-z0-9]{0,61}[a-z0-9])?\.)*(aero|arpa|asia|biz|cat|com|coop|edu|gov|info|int|jobs|mil|mobi|museum|name|net|org|pro|tel|travel|[a-z][a-z])$";
		public string Email { get; private set; } 

		public EmailForm(string email)
		{
			InitializeComponent();
			Email = email;
		}

		private void FormEmail_Load(object sender, System.EventArgs e)
			=> tbEmail.Text = Email ?? tbEmail.Text;

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(tbEmail.Text))
			{
				MessageBox.Show("E-mail field must be filled in!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				if (System.Text.RegularExpressions.Regex.IsMatch(tbEmail.Text, _emailPattern))
				{
					Email = tbEmail.Text;
					DialogResult = DialogResult.OK;
					Close();
				}
				else
					MessageBox.Show($"The email address is invalid!\n\nValid email: example@example.com",
						"Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tbEmail_TextChanged(object sender, System.EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, _emailPattern))
					textBox.BackColor = SystemColors.Window;
				else
					textBox.BackColor = Color.FromArgb(254, 203, 200);
			}
		}
	}
}