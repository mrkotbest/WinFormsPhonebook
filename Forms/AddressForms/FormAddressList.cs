using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressList : Form
	{
		public BindingList<Address> Addresses { get; private set; }
		public Address CurrentAddress { get; private set; }

		public FormAddressList(BindingList<Address> addresses)
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
			=> btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;

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
			FormAddressData form = new FormAddressData(new Address());
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
				FormAddressData form = new FormAddressData(CurrentAddress);
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
				Addresses.RemoveAt(addressListDataGridView.SelectedRows[0].Index);
		}
	}
}