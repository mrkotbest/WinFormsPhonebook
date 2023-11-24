using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonList : Form
	{
		public FormContact FormContact { get; set; }
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Person> PersonList { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPersonList(FormContact formContact, BindingList<Contact> contacts, BindingList<Person> personList, Mode mode)
		{
			InitializeComponent();

			FormContact = formContact;
			Contacts = contacts;
			PersonList = personList;
			CurrentMode = mode;

			InitializeControls();
		}

		private void InitializeControls()
		{
			peopleBindingSource.DataSource = PersonList;

			LoadPersonData();

			PersonList.ListChanged += PersonList_ListChanged;
			btnEdit.Enabled = PersonList.Count > 0;
			btnRemove.Enabled = PersonList.Count > 0;
		}
		private void LoadPersonData()
		{
			if (Contacts.Count > 0 && PersonList.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					PersonList.Add(contact.GetPerson());
				}
			}
		}
		private void UpdatePersonTextBox()
		{
			if (GetSelectedPerson() != null)
			{
				Person lastPerson = GetSelectedPerson();
				string personData = $"{lastPerson.FirstName} {lastPerson.LastName} [{lastPerson.Gender}] {lastPerson.BirthDate.ToShortDateString()}";
				FormContact.UpdateTextBox("tbPerson", personData);
			}
		}
		private Person GetSelectedPerson()
		{
			if (peopleDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = peopleDataGridView.SelectedRows[0].Index;
				return PersonList[selectedRowIndex];
			}
			return null;
		}

		private void PersonList_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
			{
				UpdatePersonTextBox();
			}

			btnEdit.Enabled = btnRemove.Enabled = PersonList.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormPersonData formPersonData = new FormPersonData(PersonList, Mode.Add);
			formPersonData.ShowDialog();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Person selectedPerson = GetSelectedPerson();
			if (selectedPerson != null)
			{
				FormPersonData formPersonData = new FormPersonData(FormContact, PersonList, Mode.Edit, selectedPerson);
				formPersonData.ShowDialog();
				peopleDataGridView.Refresh();
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			Person selectedPerson = GetSelectedPerson();
			if (selectedPerson != null)
			{
				PersonList.Remove(selectedPerson);
				peopleDataGridView.Refresh();
			}
		}

		private void FormPersonList_FormClosed(object sender, FormClosedEventArgs e)
		{
			UpdatePersonTextBox();
			FormContact.SelectedPerson = GetSelectedPerson();
			if (PersonList.Count == 0)
				FormContact.UpdateTextBox("tbPerson", string.Empty);
		}
	}
}