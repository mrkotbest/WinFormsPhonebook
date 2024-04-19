using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.EmailForms
{
	public partial class FormEmail : Form
	{
		private readonly Email _tempEmail;
		public Email Email { get; set; } 

		public FormEmail(Email email)
		{
			InitializeComponent();
			Email = email;
			_tempEmail = email.Clone();
		}

		private void FormEmail_Load(object sender, System.EventArgs e)
			=> emailBS.DataSource = _tempEmail ?? emailBS.DataSource;

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(tbEmail.Text))
			{
				MessageBox.Show("E-mail field must be filled in!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Email.CopyFrom(_tempEmail);

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void tbEmail_TextChanged(object sender, System.EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				textBox.Text = textBox.Text.ToLower();  // Convert text to lowercase.
				textBox.SelectionStart = textBox.Text.Length;   // Place the cursor at the end of the text.
			}
		}
	}
}