using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonList : Form
	{
		public BindingList<Person> Persons { get; set; }

		public FormPersonList(BindingList<Person> persons)
		{
			InitializeComponent();

			Persons = persons;

			InitializeControls();
		}

		public int GetSelectedPersonIndex()
		{
			return peopleDataGridView.SelectedRows[0].Index;
		}
		private void InitializeControls()
		{
			peopleBindingSource.DataSource = Persons;

			if (Persons != null)
			{
				Persons.ListChanged += PersonList_ListChanged;
				btnEdit.Enabled = Persons.Count > 0;
				btnRemove.Enabled = Persons.Count > 0;
			}
		}

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