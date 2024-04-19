using System.Windows.Forms;

namespace WF_Phonebook.Forms.EmailForms
{
	public partial class FormEmail : Form
	{
		public string Email { get; private set; } 

		public FormEmail(string email)
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
				Email = tbEmail.Text;

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