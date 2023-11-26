using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonList : Form
	{
		public BindingList<Person> Persons { get; set; }
		public int SelectedPersonIndex { get; private set; } = -1;

		public FormPersonList(BindingList<Person> persons)
		{
			InitializeComponent();
			Persons = persons;
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
			Person selectedPerson = Persons[SelectedPersonIndex];

			FormPersonData formPersonData = new FormPersonData(Mode.Edit, selectedPerson);
			if (formPersonData.ShowDialog() == DialogResult.OK)
			{
				Persons[SelectedPersonIndex] = formPersonData.Person;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (peopleDataGridView.SelectedRows.Count > 0)
			{
				Persons.RemoveAt(SelectedPersonIndex);
			}
		}

		private void InitializeControls()
		{
			peopleBindingSource.DataSource = Persons;

			if (Persons != null)
			{
				Persons.ListChanged += PersonList_ListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;
			}
		}
		
		private void peopleDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			SelectedPersonIndex = peopleDataGridView.SelectedRows.Count > 0 ? peopleDataGridView.SelectedRows[0].Index : -1;
		}
		private void PersonList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;
		}

		private void FormPersonList_Load(object sender, EventArgs e)
		{
			InitializeControls();
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