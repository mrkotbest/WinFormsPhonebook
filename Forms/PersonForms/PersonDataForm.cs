using System;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.PersonForms
{
	public partial class PersonDataForm : Form
	{
		private readonly Person _tempPerson;
		public Person Person { get; } 

		public PersonDataForm(Person person)
		{
			InitializeComponent();
			Person = person;
			_tempPerson = person.Clone();
		}

		private void FormPersonData_Load(object sender, EventArgs e)
			=> formPersonDataBindingSource.DataSource = _tempPerson ?? formPersonDataBindingSource.DataSource;

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastName.Text) || string.IsNullOrEmpty(tbGender.Text))
			{
				MessageBox.Show("All fields must be filled in!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Person.CopyFrom(_tempPerson);

				DialogResult = DialogResult.OK;
				Close();
			}
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