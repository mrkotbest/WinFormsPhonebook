using System;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonData : Form
	{
		public Person Person { get; }

		public FormPersonData(Person person)
		{
			InitializeComponent();
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
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void FormPersonData_Load(object sender, EventArgs e)
		{
			formPersonDataBindingSource.DataSource = Person ?? formPersonDataBindingSource.DataSource;
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

		// Checking if a symbol is a letter or a control symbol (eg "Backspace").
		private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbGender_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}