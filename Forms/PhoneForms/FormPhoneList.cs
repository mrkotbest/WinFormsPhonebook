using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPhoneList : Form
	{
		public BindingList<Phone> Phones { get; set; }
		public int SelectedPhoneIndex { get; private set; } = -1;

		public FormPhoneList(BindingList<Phone> phones)
		{
			InitializeComponent();
			Phones = phones;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormPhoneData form = new FormPhoneData(new Phone());
			if (form.ShowDialog() == DialogResult.OK)
			{
				Phones.Add(form.Phone);
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Phone selectedPhone = Phones[SelectedPhoneIndex];
			FormPhoneData form = new FormPhoneData(selectedPhone);
			if (form.ShowDialog() == DialogResult.OK)
			{
				Phones[SelectedPhoneIndex] = form.Phone;
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (phoneListDataGridView.SelectedRows.Count > 0)
			{
				Phones.RemoveAt(SelectedPhoneIndex);
			}
		}

		private void InitializeControls()
		{
			phoneListBindingSource.DataSource = Phones;

			Phones.ListChanged += PhoneList_ListChanged;
			btnEdit.Enabled = btnRemove.Enabled = Phones.Count > 0;
		}

		private void phoneListDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			SelectedPhoneIndex = phoneListDataGridView.SelectedRows.Count > 0 ? phoneListDataGridView.SelectedRows[0].Index : -1;
		}
		private void PhoneList_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Phones.Count > 0;
		}

		private void FormPhoneList_Load(object sender, EventArgs e)
		{
			InitializeControls();
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