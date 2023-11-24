using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonData : Form
	{
		public FormContact FormContact { get; set; }
		public BindingList<Person> PersonList { get; set; }
		public Person CurrentPerson { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPersonData(BindingList<Person> personList, Mode mode, Person person = null) : this(null, personList, mode, person) { }
		public FormPersonData(FormContact formContact, BindingList<Person> personList, Mode mode, Person person = null)
		{
			InitializeComponent();

			FormContact = formContact;
			PersonList = personList;
			CurrentMode = mode;
			CurrentPerson = person;

			if (CurrentMode == Mode.Edit && CurrentPerson != null)
			{
				tbFirstName.Text = CurrentPerson.FirstName;
				tbLastName.Text = CurrentPerson.LastName;
				tbGender.Text = CurrentPerson.Gender;
				dpBirthDate.Value = CurrentPerson.BirthDate.Date;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbFirstName.Text == string.Empty | tbLastName.Text == string.Empty | tbGender.Text == string.Empty)
			{
				MessageBox.Show("All fields must be filled in.", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				if (CurrentMode == Mode.Add)
				{
					PersonList.Add(new Person(tbFirstName.Text, tbLastName.Text, tbGender.Text, dpBirthDate.Value.Date));
				}
				else if (CurrentMode == Mode.Edit && CurrentPerson == null)
				{
					Person tempPerson = new Person(tbFirstName.Text, tbLastName.Text, tbGender.Text, dpBirthDate.Value.Date);
					FormContact.SelectedPerson = tempPerson;
				}
				else if (CurrentMode == Mode.Edit && CurrentPerson != null)
				{
					CurrentPerson.FirstName = tbFirstName.Text;
					CurrentPerson.LastName = tbLastName.Text;
					CurrentPerson.Gender = tbGender.Text;
					CurrentPerson.BirthDate = dpBirthDate.Value.Date;
				}
				Close();
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
	}
}