using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonList : Form
	{
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Person> Persons { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPersonList(BindingList<Contact> contacts, BindingList<Person> persons, Mode mode)
		{
			InitializeComponent();

			Contacts = contacts;
			Persons = persons;
			CurrentMode = mode;

			InitializeControls();
		}

		public int GetSelectedPersonIndex()
		{
			return peopleDataGridView.SelectedRows[0].Index;
		}
		private void InitializeControls()
		{
			peopleBindingSource.DataSource = Persons;

			LoadPersonData();

			if (Persons != null)
			{
				Persons.ListChanged += PersonList_ListChanged;
				btnEdit.Enabled = Persons.Count > 0;
				btnRemove.Enabled = Persons.Count > 0;
			}
		}
		private void LoadPersonData()
		{
			if (Persons != null && Persons.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					Persons.Add(contact.GetPerson());
				}
			}
		}
		//private Person GetSelectedPerson()
		//{
		//	if (peopleDataGridView.SelectedRows.Count == 1)
		//	{
		//		int selectedRowIndex = GetSelectedPersonIndex();
		//		return Persons[selectedRowIndex];
		//	}
		//	return null;
		//}

		private void PersonList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormPersonData formPersonData = new FormPersonData(Mode.Add, new Person());
			if (formPersonData.ShowDialog() == DialogResult.OK)
			{
				Persons.Add(formPersonData.Person);
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedPersonIndex();
			Person selectedPerson = Persons[selectedIndex];

			FormPersonData formPersonData = new FormPersonData(Mode.Edit, selectedPerson);
			if (formPersonData.ShowDialog() == DialogResult.OK)
			{
				Persons[selectedIndex] = formPersonData.Person;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (peopleDataGridView.SelectedRows.Count > 0)
			{
				int selectedIndex = GetSelectedPersonIndex();
				Persons.RemoveAt(selectedIndex);
			}
		}

		private void FormPersonList_FormClosed(object sender, FormClosedEventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}