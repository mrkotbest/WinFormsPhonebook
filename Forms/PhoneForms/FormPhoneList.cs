using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneList : Form
	{
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Phone> Phones { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPhoneList(BindingList<Contact> contacts, BindingList<Phone> phones, Mode mode)
		{
			InitializeComponent();

			Contacts = contacts;
			Phones = phones;
			CurrentMode = mode;

			InitializeControls();
		}

		private void InitializeControls()
		{
			phoneListBindingSource.DataSource = Phones;

			LoadPhoneData();

			Phones.ListChanged += PhoneList_ListChanged;
			btnEdit.Enabled = Phones.Count > 0;
			btnRemove.Enabled = Phones.Count > 0;
		}
		private void LoadPhoneData()
		{
			if (Phones != null && Phones.Count == 0)
			{
				foreach (Contact contact in Contacts)
				{
					Phones.Add(contact.GetPhone());
				}
			}
		}
		public int GetSelectedPhoneIndex()
		{
			return phoneListDataGridView.SelectedRows[0].Index;
		}
		//private Phone GetSelectedPhone()
		//{
		//	if (phoneListDataGridView.SelectedRows.Count == 1)
		//	{
		//		int selectedRowIndex = GetSelectedPhoneIndex();
		//		return Phones[selectedRowIndex];
		//	}
		//	return null;
		//}

		private void PhoneList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Phones.Count > 0;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormPhoneData formPhoneData = new FormPhoneData(Mode.Add, new Phone());
			if (formPhoneData.ShowDialog() == DialogResult.OK)
			{
				Phones.Add(formPhoneData.Phone);
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedIndex = GetSelectedPhoneIndex();
			Phone selectedPhone = Phones[selectedIndex];

			FormPhoneData formPhoneData = new FormPhoneData(Mode.Edit, selectedPhone);
			if (formPhoneData.ShowDialog() == DialogResult.OK)
			{
				Phones[selectedIndex] = formPhoneData.Phone;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (phoneListDataGridView.SelectedRows.Count > 0)
			{
				int selectedIndex = GetSelectedPhoneIndex();
				Phones.RemoveAt(selectedIndex);
			}
		}

		private void FormPhoneList_FormClosed(object sender, FormClosedEventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}