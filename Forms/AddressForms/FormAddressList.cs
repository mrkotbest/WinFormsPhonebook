using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressList : Form
	{
		public BindingList<Address> Addresses { get; set; }
		public int SelectedAddressIndex { get; private set; } = -1;

		public FormAddressList(BindingList<Address> addresses)
		{
			InitializeComponent();
			Addresses = addresses;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormAddressData form = new FormAddressData(new Address());
			if (form.ShowDialog() == DialogResult.OK)
			{
				Addresses.Add(form.Address);
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Address selectedAddress = Addresses[SelectedAddressIndex];
			FormAddressData form = new FormAddressData(selectedAddress);
			if (form.ShowDialog() == DialogResult.OK)
			{
				Addresses[SelectedAddressIndex] = form.Address;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (addressListDataGridView.SelectedRows.Count > 0)
			{
				Addresses.RemoveAt(SelectedAddressIndex);
			}
		}

		private void InitializeControls()
		{
			addressListBindingSource.DataSource = Addresses;

			Addresses.ListChanged += AddressList_ListChanged;
			btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;
		}

		private void addressListDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			SelectedAddressIndex = addressListDataGridView.SelectedRows.Count > 0 ? addressListDataGridView.SelectedRows[0].Index : -1;
		}
		private void AddressList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;
		}

		private void FormAddressList_Load(object sender, EventArgs e)
		{
			InitializeControls();
		}
		private void FormAddressList_FormClosed(object sender, FormClosedEventArgs e)
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