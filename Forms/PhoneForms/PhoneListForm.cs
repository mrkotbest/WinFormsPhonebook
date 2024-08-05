using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using WF_Phonebook.Forms.MainForms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.PhoneForms
{
	public partial class PhoneListForm : Form
	{
		public BindingList<Phone> Phones { get; private set; }
		public Phone CurrentPhone { get; private set; }

		public PhoneListForm(BindingList<Phone> phones)
		{
			InitializeComponent();
			Phones = phones;
		}

		private void FormPhoneList_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			if (Phones != null)
			{
				phoneListBindingSource.DataSource = Phones;

				Phones.ListChanged += HandleListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Phones.Count > 0;

				if (MainForm.CurrentContact != null)
					SelectRowByPhone(phoneListDataGridView, MainForm.CurrentContact.Phone);
			}
		}

		private void HandleListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Phones.Count > 0;

			if (e.ListChangedType == ListChangedType.ItemDeleted)
			{
				if (CurrentPhone != null && !Phones.Contains(CurrentPhone))
					CurrentPhone = null;
			}
		}

		private void SelectRowByPhone(DataGridView dataGrid, Phone phone)
		{
			if (dataGrid == null || phone == null)
				return;

			var selectedRow = dataGrid.Rows
				.Cast<DataGridViewRow>()
				.FirstOrDefault(row => row.DataBoundItem is Phone ph && ph.Id == phone.Id);

			if (selectedRow != null)
			{
				dataGrid.ClearSelection();
				selectedRow.Selected = true;
			}
		}

		private void phoneListDataGridView_SelectionChanged(object sender, EventArgs e)
			=> CurrentPhone = phoneListDataGridView.SelectedRows.Count > 0 ? Phones[phoneListDataGridView.SelectedRows[0].Index] : null;

		private void phoneListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				CurrentPhone = Phones[e.RowIndex];
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (PhoneDataForm form = new PhoneDataForm(new Phone()))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					form.Phone.Id = Phones.Any() ? Phones.Max(p => p.Id) + 1 : 0;
					Phones.Add(form.Phone);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (CurrentPhone != null)
			{
				using (PhoneDataForm form = new PhoneDataForm(CurrentPhone))
				{
					if (form.ShowDialog() == DialogResult.OK)
						Phones[phoneListDataGridView.SelectedRows[0].Index] = form.Phone;
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to remove the item?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			if (phoneListDataGridView.SelectedRows.Count > 0)
			{
				Phone phoneToRemove = Phones[phoneListDataGridView.SelectedRows[0].Index];
				try
				{
					if (phoneToRemove == null)
					{
						MessageBox.Show("The selected phone is invalid. Please select a valid phone to remove.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					bool isUsedInContacts = MainForm.IsUsedInContacts(phoneToRemove, Phones);

					if (isUsedInContacts)
					{
						MessageBox.Show(this, "This phone is used in one or more contacts and cannot be removed.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (Phones.Contains(phoneToRemove))
						Phones.Remove(phoneToRemove);
				}
				catch (ArgumentException ex)
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