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
			if (Persons != null)
			{
				peopleBindingSource.DataSource = Persons;

				Persons.ListChanged += OnListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;

				if (MainForm.CurrentContact != null)
					SelectRowByPerson(peopleDataGridView, MainForm.CurrentContact.Person);
			}
		}

		private void OnListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Persons.Count > 0;
			if (e.ListChangedType == ListChangedType.ItemDeleted)
			{
				if (CurrentPerson != null && !Persons.Contains(CurrentPerson))
					CurrentPerson = null;
			}
		}

		private void SelectRowByPerson(DataGridView dataGrid, Person person)
		{
			if (dataGrid == null || person == null)
				return;

			var selectedRow = dataGrid.Rows
				.Cast<DataGridViewRow>()
				.FirstOrDefault(row => row.DataBoundItem is Person p && p.Id == person.Id);

			if (selectedRow != null)
			{
				dataGrid.ClearSelection();
				selectedRow.Selected = true;
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
			using (var form = new PersonDataForm(new Person()))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					form.Person.Id = Persons.Any() ? Persons.Max(p => p.Id) + 1 : 0;
					Persons.Add(form.Person);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (CurrentPerson != null)
			{
				using (var form = new PersonDataForm(CurrentPerson))
				{
					if (form.ShowDialog() == DialogResult.OK)
						Persons[peopleDataGridView.SelectedRows[0].Index] = form.Person;
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to remove the item?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			if (peopleDataGridView.SelectedRows.Count > 0)
			{
				var personToRemove = Persons[peopleDataGridView.SelectedRows[0].Index];
				try
				{
					if (personToRemove == null)
					{
						MessageBox.Show("The selected person is invalid. Please select a valid person to remove.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					bool isUsedInContacts = MainForm.IsUsedInContacts(personToRemove, Persons);

					if (isUsedInContacts)
					{
						MessageBox.Show(this, "This person is used in one or more contacts and cannot be removed.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (Persons.Contains(personToRemove))
						Persons.Remove(personToRemove);
				}
				catch(ArgumentException ex)
				{
					MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}