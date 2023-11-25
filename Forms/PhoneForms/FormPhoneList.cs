using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneList : Form
	{
		public BindingList<Phone> Phones { get; set; }

		public FormPhoneList(BindingList<Phone> phones)
		{
			InitializeComponent();

			Phones = phones;

			InitializeControls();
		}

		public int GetSelectedPhoneIndex()
		{
			return phoneListDataGridView.SelectedRows[0].Index;
		}
		private void InitializeControls()
		{
			phoneListBindingSource.DataSource = Phones;

			Phones.ListChanged += PhoneList_ListChanged;
			btnEdit.Enabled = Phones.Count > 0;
			btnRemove.Enabled = Phones.Count > 0;
		}

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