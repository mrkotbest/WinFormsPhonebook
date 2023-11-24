using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressList : Form
	{
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Address> Addresses { get; set; }
		public Mode CurrentMode { get; set; }

		public FormAddressList(BindingList<Contact> contacts, BindingList<Address> addresses, Mode mode)
		{
			InitializeComponent();

			Contacts = contacts;
			Addresses = addresses;
			CurrentMode = mode;

			InitializeControls();
		}

		public int GetSelectedAddressIndex()
		{
			return addressListDataGridView.SelectedRows[0].Index;
		}
		private void InitializeControls()
		{
			addressListBindingSource.DataSource = Addresses;

			LoadAddressData();

			Addresses.ListChanged += AddressList_ListChanged;
			btnEdit.Enabled = Addresses.Count > 0;
			btnRemove.Enabled = Addresses.Count > 0;
		}
		private void LoadAddressData()
		{
			if (Addresses != null && Addresses.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					Addresses.Add(contact.GetAddress());
				}
			}
		}
		//private Address GetSelectedAddress()
		//{
		//	if (addressListDataGridView.SelectedRows.Count == 1)
		//	{
		//		int selectedRowIndex = GetSelectedAddressIndex();
		//		return Addresses[selectedRowIndex];
		//	}
		//	return null;
		//}

		private void AddressList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Addresses.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormAddressData formAddressData = new FormAddressData(Mode.Add, new Address());
			if (formAddressData.ShowDialog() == DialogResult.OK)
			{
				Addresses.Add(formAddressData.Address);
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedAddressIndex();
			Address selectedAddress = Addresses[selectedIndex];

			FormAddressData formAddressData = new FormAddressData(Mode.Edit, selectedAddress);
			if (formAddressData.ShowDialog() == DialogResult.OK)
			{
				Addresses[selectedIndex] = formAddressData.Address;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (addressListDataGridView.SelectedRows.Count > 0)
			{
				int selectedIndex = GetSelectedAddressIndex();
				Addresses.RemoveAt(selectedIndex);
			}
		}

		private void FormAddressList_FormClosed(object sender, FormClosedEventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}