using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Forms.MainForms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.PersonForms
{
	public partial class PersonListForm : Form
	{
		public BindingList<Person> Persons { get; private set; }
		public Person CurrentPerson { get; private set; }

		public PersonListForm(BindingList<Person> persons)
		{
			InitializeComponent();
			Persons = persons;
		}

		private void FormPersonList_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			peopleBindingSource.DataSource = Persons;

			if (Persons != null)
			{
				Persons.ListChanged += HandleListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;
			}
		}

		private void HandleListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;

			if (e.ListChangedType == ListChangedType.ItemDeleted)
			{
				if (CurrentPerson != null && !Persons.Contains(CurrentPerson))
					CurrentPerson = null;
			}
		}

		private void peopleDataGridView_SelectionChanged(object sender, EventArgs e)
			=> CurrentPerson = peopleDataGridView.SelectedRows.Count > 0 ? Persons[peopleDataGridView.SelectedRows[0].Index] : null;
		
		private void peopleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				CurrentPerson = Persons[e.RowIndex];
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			PersonDataForm form = new PersonDataForm(new Person());
			if (form.ShowDialog() == DialogResult.OK)
			{
				form.Person.Id = Persons.Any() ? Persons.Max(p => p.Id) + 1 : 0;
				Persons.Add(form.Person);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (CurrentPerson != null)
			{
				PersonDataForm form = new PersonDataForm(CurrentPerson);
				if (form.ShowDialog() == DialogResult.OK)
					Persons[peopleDataGridView.SelectedRows[0].Index] = form.Person;
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to remove the item?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			if (peopleDataGridView.SelectedRows.Count > 0)
			{
				Person personToRemove = Persons[peopleDataGridView.SelectedRows[0].Index];

				bool isUsedInContacts = MainForm.IsUsedInContacts(personToRemove);

				if (isUsedInContacts)
				{
					MessageBox.Show("This person data is used in one or more contacts and cannot be removed.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Persons.Remove(personToRemove);
			}
		}
	}
}