using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressList : Form
	{
		public FormContact FormContact { get; set; }
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Address> AddressList { get; set; }
		public Mode CurrentMode { get; set; }

		public FormAddressList(FormContact formContact,
			BindingList<Contact> contacts, BindingList<Address> addressList, Mode mode)
		{
			InitializeComponent();

			FormContact = formContact;
			Contacts = contacts;
			AddressList = addressList;
			CurrentMode = mode;

			InitializeControls();
		}

		private void InitializeControls()
		{
			addressListBindingSource.DataSource = AddressList;

			LoadAddressData();

			AddressList.ListChanged += AddressList_ListChanged;
			btnEdit.Enabled = AddressList.Count > 0;
			btnRemove.Enabled = AddressList.Count > 0;
		}
		private void LoadAddressData()
		{
			if (Contacts.Count > 0 && AddressList.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					AddressList.Add(contact.GetAddress());
				}
			}
		}
		private void UpdateAddressTextBox()
		{
			if (GetSelectedAddress() != null)
			{
				Address lastAddress = GetSelectedAddress();
				string addressData = $"{lastAddress.Street} {lastAddress.HouseNo}/{lastAddress.ApartmentNo}";
				FormContact.UpdateTextBox("tbAddress", addressData);
			}
		}
		private Address GetSelectedAddress()
		{
			if (addressListDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = addressListDataGridView.SelectedRows[0].Index;
				return AddressList[selectedRowIndex];
			}
			return null;
		}

		private void AddressList_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
			{
				UpdateAddressTextBox();
			}

			btnEdit.Enabled = btnRemove.Enabled = AddressList.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormAddressData formAddressData = new FormAddressData(AddressList, Mode.Add);
			formAddressData.ShowDialog();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Address selectedAddress = GetSelectedAddress();
			if (selectedAddress != null)
			{
				FormAddressData formAddressData = new FormAddressData(AddressList, Mode.Edit, selectedAddress);
				formAddressData.ShowDialog();
				addressListDataGridView.Refresh();
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			Address selectedAddress = GetSelectedAddress();
			if (selectedAddress != null)
			{
				AddressList.Remove(selectedAddress);
				addressListDataGridView.Refresh();
			}
		}

		private void FormAddressList_FormClosed(object sender, FormClosedEventArgs e)
		{
			UpdateAddressTextBox();
			FormContact.SelectedAddress = GetSelectedAddress();
			if (AddressList.Count == 0)
				FormContact.UpdateTextBox("tbAddress", string.Empty);
		}
	}
}