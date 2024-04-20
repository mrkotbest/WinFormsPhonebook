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
			addressListBindingSource.DataSource = Addresses;

			if (Addresses != null)
			{
				Addresses.ListChanged += HandleListChanged;
				btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;
			}
		}

		private void HandleListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;

			if (e.ListChangedType == ListChangedType.ItemDeleted)
			{
				if (CurrentAddress != null && !Addresses.Contains(CurrentAddress))
					CurrentAddress = null;
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
			AddressDataForm form = new AddressDataForm(new Address());
			if (form.ShowDialog() == DialogResult.OK)
			{
				form.Address.Id = Addresses.Any() ? Addresses.Max(p => p.Id) + 1 : 0;
				Addresses.Add(form.Address);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (CurrentAddress != null)
			{
				AddressDataForm form = new AddressDataForm(CurrentAddress);
				if (form.ShowDialog() == DialogResult.OK)
					Addresses[addressListDataGridView.SelectedRows[0].Index] = form.Address;
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

				bool isUsedInContacts = MainForm.IsUsedInContacts(addressToRemove);

				if (isUsedInContacts)
				{
					MessageBox.Show("This address data is used in one or more contacts and cannot be removed.", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Addresses.Remove(addressToRemove);
			}
		}
	}
}