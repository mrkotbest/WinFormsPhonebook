using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneList : Form
	{
		public FormContact FormContact { get; set; }
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Phone> PhoneList { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPhoneList(FormContact formContact,
			BindingList<Contact> contacts, BindingList<Phone> phoneList, Mode mode)
		{
			InitializeComponent();

			FormContact = formContact;
			Contacts = contacts;
			PhoneList = phoneList;
			CurrentMode = mode;

			InitializeControls();
		}

		private void InitializeControls()
		{
			phoneListBindingSource.DataSource = PhoneList;

			LoadPhoneData();

			PhoneList.ListChanged += PhoneList_ListChanged;
			btnEdit.Enabled = PhoneList.Count > 0;
			btnRemove.Enabled = PhoneList.Count > 0;
		}
		private void LoadPhoneData()
		{
			if (Contacts.Count > 0 && PhoneList.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					PhoneList.Add(contact.GetPhone());
				}
			}
		}
		private void UpdatePhoneTextBox()
		{
			if (GetSelectedPhone() != null)
			{
				Phone lastPhone = GetSelectedPhone();
				string phoneData = $"{lastPhone.Number} ({lastPhone.Type})";
				FormContact.UpdateTextBox("tbPhone", phoneData);
			}
		}
		private Phone GetSelectedPhone()
		{
			if (phoneListDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = phoneListDataGridView.SelectedRows[0].Index;
				return PhoneList[selectedRowIndex];
			}
			return null;
		}

		private void PhoneList_ListChanged(object sender, ListChangedEventArgs e)
		{
			if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
			{
				UpdatePhoneTextBox();
			}

			btnEdit.Enabled = btnRemove.Enabled = PhoneList.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormPhoneData formPhoneData = new FormPhoneData(PhoneList, Mode.Add);
			formPhoneData.ShowDialog();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Phone selectedPhone = GetSelectedPhone();
			if (selectedPhone != null)
			{
				FormPhoneData formPhoneData = new FormPhoneData(PhoneList, Mode.Edit, selectedPhone);
				formPhoneData.ShowDialog();
				phoneListDataGridView.Refresh();
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			Phone selectedPhone = GetSelectedPhone();
			if (selectedPhone != null)
			{
				PhoneList.Remove(selectedPhone);
				phoneListDataGridView.Refresh();
			}
		}

		private void FormPhoneList_FormClosed(object sender, FormClosedEventArgs e)
		{
			UpdatePhoneTextBox();
			FormContact.SelectedPhone = GetSelectedPhone();
			if (PhoneList.Count == 0)
				FormContact.UpdateTextBox("tbPhone", string.Empty);
		}
	}
}