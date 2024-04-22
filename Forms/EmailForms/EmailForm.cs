using System.Windows.Forms;

namespace WF_Phonebook.Forms.EmailForms
{
	public partial class EmailForm : Form
	{
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
				Email = tbEmail.Text;
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}