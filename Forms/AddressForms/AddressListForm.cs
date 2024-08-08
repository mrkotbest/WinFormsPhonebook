using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Forms.MainForms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms.AddressForms
{
	public partial class AddressListForm : Form
	{
		public BindingList<Address> Addresses { get; private set; }
		public Address CurrentAddress { get; private set; }

		public AddressListForm(BindingList<Address> addresses)
		{
			InitializeComponent();
			Addresses = addresses;
		}

		private void FormAddressList_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			if (Addresses != null)
			{
				addressListBindingSource.DataSource = Addresses;

				Addresses.ListChanged += OnListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;

				if (MainForm.CurrentContact != null)
					SelectRowByAddress(addressListDataGridView, MainForm.CurrentContact.Address);
			}
		}

		private void OnListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;
			if (e.ListChangedType == ListChangedType.ItemDeleted)
			{
				if (CurrentAddress != null && !Addresses.Contains(CurrentAddress))
					CurrentAddress = null;
			}
		}

		private void SelectRowByAddress(DataGridView dataGrid, Address address)
		{
			if (dataGrid == null || address == null)
				return;

			var selectedRow = dataGrid.Rows
				.Cast<DataGridViewRow>()
				.FirstOrDefault(row => row.DataBoundItem is Address a && a.Id == address.Id);

			if (selectedRow != null)
			{
				dataGrid.ClearSelection();
				selectedRow.Selected = true;
			}
		}

		private void addressListDataGridView_SelectionChanged(object sender, EventArgs e)
			=> CurrentAddress = addressListDataGridView.SelectedRows.Count > 0 ? Addresses[addressListDataGridView.SelectedRows[0].Index] : null;
		
		private void addressListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				CurrentAddress = Addresses[e.RowIndex];
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (AddressDataForm form = new AddressDataForm(new Address()))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					form.Address.Id = Addresses.Any() ? Addresses.Max(p => p.Id) + 1 : 0;
					Addresses.Add(form.Address);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (CurrentAddress != null)
			{
				using (AddressDataForm form = new AddressDataForm(CurrentAddress))
				{
					if (form.ShowDialog() == DialogResult.OK)
						Addresses[addressListDataGridView.SelectedRows[0].Index] = form.Address;
				}
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to remove the item?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;

			if (addressListDataGridView.SelectedRows.Count > 0)
			{
				Address addressToRemove = Addresses[addressListDataGridView.SelectedRows[0].Index];
				try
				{
					if (addressToRemove == null)
					{
						MessageBox.Show("The selected address is invalid. Please select a valid address to remove.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					bool isUsedInContacts = MainForm.IsUsedInContacts(addressToRemove, Addresses);

					if (isUsedInContacts)
					{
						MessageBox.Show(this, "This address is used in one or more contacts and cannot be removed.", "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					if (Addresses.Contains(addressToRemove))
						Addresses.Remove(addressToRemove);
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