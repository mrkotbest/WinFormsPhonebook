using System;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonData : Form
	{
		public Mode CurrentMode { get; }
		public Person Person { get; set; }

		public FormPersonData(Mode mode, Person person = null)
		{
			InitializeComponent();
			CurrentMode = mode;
			Person = person;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbGender.Text))
			{
				MessageBox.Show("All fields must be filled in.", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Person = new Person(tbFirstName.Text, tbLastName.Text, tbGender.Text, dpBirthDate.Value.Date);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void FormPersonData_Load(object sender, EventArgs e)
		{
			if (CurrentMode == Mode.Edit && Person != null)
			{
				formPersonDataBindingSource.DataSource = Person;
			}
		}

		private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbGender_KeyPress(object sender, KeyPressEventArgs e)
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