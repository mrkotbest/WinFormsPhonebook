using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using WF_Phonebook.Forms.AddressForms;
using WF_Phonebook.Forms.EmailForms;
using WF_Phonebook.Forms.PersonForms;
using WF_Phonebook.Forms.PhoneForms;
using WF_Phonebook.Models;
using WF_Phonebook.Services;

namespace WF_Phonebook.Forms.MainForms
{
	public partial class MainForm : Form
	{
		private const string _xmlFileName = "contacts.xml";
		private const string _backupFileName = _xmlFileName + ".bak";

		private static PhonebookStore _store;

		public static Contact CurrentContact { get; private set; }

		public MainForm()
			=> InitializeComponent();

		private void FormMain_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			LoadData();

			contactsBindingSource.DataSource = _store.Contacts;

			_store.Contacts.ListChanged += (sender, e) => { btnEdit.Enabled = btnRemove.Enabled = _store.Contacts.Count > 0; };
			btnEdit.Enabled = btnRemove.Enabled = _store.Contacts.Count > 0;
		}

		private void LoadData()
		{
			if (!File.Exists(_xmlFileName) || new FileInfo(_xmlFileName).Length == 0)
			{
				_store = new PhonebookStore();
				return;
			}

			try
			{
				using (var fs = new FileStream(_xmlFileName, FileMode.Open))
				{
					var formatter = new XmlSerializer(typeof(PhonebookStore));
					var store = formatter.Deserialize(fs) as PhonebookStore;

					if (store is null)
						throw new ArgumentNullException(nameof(store), "Store cannot be null. Please ensure that a valid store instance is provided.");

					_store = new PhonebookStore(store.Contacts, store.Persons, store.Addresses, store.Phones);
				}
			}
			catch (Exception ex)
			{
				File.AppendAllText("error.log", $"[{DateTime.Now}] loading data error: {ex.Message}\n");

				if (File.Exists(_backupFileName))
				{
					File.Copy(_backupFileName, _xmlFileName, true);
					MessageBox.Show($"An error occurred while loading: {ex.Message}\n\nThe data has been restored from the latest backup.",
						"Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					LoadData();
				}
				else
				{
					_store = new PhonebookStore();
					MessageBox.Show("An error occurred while loading..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private bool SaveData()
		{
			try
			{
				var formatter = new XmlSerializer(typeof(PhonebookStore));
				using (FileStream fs = new FileStream(_xmlFileName, FileMode.Create))
				{
					formatter.Serialize(fs, _store);
				}

				File.Copy(_xmlFileName, _backupFileName, true);
				return true;
			}
			catch (Exception ex)
			{
				File.AppendAllText("error.log", $"[{DateTime.Now}] saving data error: {ex.Message}\n");
				MessageBox.Show("An error occurred while saving..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (SaveData())
				MessageBox.Show("Contacts are saved!\n\n(Saving occurs automatically when you exit the application)",
								"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			using (var form = new ContactForm(_store))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					_store.Contacts.Add(form.CreatedNewContact);
					contactsDataGridView.Refresh();
				}
			}
		}

		public static int GenerateNewContactId()
			=> _store.Contacts.Any() ? _store.Contacts.Max(c => c.ContactId) + 1 : 0;

		private void tsPersonItem_Click(object sender, EventArgs e)
			=> OpenPersonListForm();

		private void tsAddressItem_Click(object sender, EventArgs e)
			=> OpenAddressListForm();

		private void tsPhoneItem_Click(object sender, EventArgs e)
			=> OpenPhoneListForm();

		private void tsEmailItem_Click(object sender, EventArgs e)
			=> OpenEmailForm();

		private void OpenPersonListForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new PersonListForm(_store.Persons))
			{
				if (form.ShowDialog() == DialogResult.OK || _store.Contacts[contactsDataGridView.SelectedRows[0].Index].Person.Id == form.CurrentPerson.Id)
					_store.Contacts[contactsDataGridView.SelectedRows[0].Index].Person = form.CurrentPerson;
				contactsDataGridView.Refresh();
			}
		}

		private void OpenAddressListForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new AddressListForm(_store.Addresses))
			{
				if (form.ShowDialog() == DialogResult.OK || _store.Contacts[contactsDataGridView.SelectedRows[0].Index].Address.Id == form.CurrentAddress.Id)
					_store.Contacts[contactsDataGridView.SelectedRows[0].Index].Address = form.CurrentAddress;
				contactsDataGridView.Refresh();
			}
		}

		private void OpenPhoneListForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new PhoneListForm(_store.Phones))
			{
				if (form.ShowDialog() == DialogResult.OK || _store.Contacts[contactsDataGridView.SelectedRows[0].Index].Phone.Id == form.CurrentPhone.Id)
					_store.Contacts[contactsDataGridView.SelectedRows[0].Index].Phone = form.CurrentPhone;
				contactsDataGridView.Refresh();
			}
		}

		private void OpenEmailForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new EmailForm(CurrentContact.Email))
			{
				if (form.ShowDialog() == DialogResult.OK)
					_store.Contacts[contactsDataGridView.SelectedRows[0].Index].Email = form.Email;
				contactsDataGridView.Refresh();
			}
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Are you sure to remove this record?", "Removal warning",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					_store.Contacts.RemoveAt(contactsDataGridView.SelectedRows[0].Index);

					if (contactsDataGridView.Rows.Count > 0)
						contactsDataGridView.FirstDisplayedCell.Selected = true;
				}
			}
		}

		private void contactsDataGridView_SelectionChanged(object sender, EventArgs e)
			=> RefreshCurrentContactFromDGV();

		private void RefreshCurrentContactFromDGV()
			=> CurrentContact = contactsDataGridView.SelectedRows.Count > 0 ? _store.Contacts[contactsDataGridView.SelectedRows[0].Index] : null;

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
			=> SaveData();

		public static bool IsUsedInContacts<T>(T item, BindingList<T> list) where T : class
		{
			if (item == null || list == null)
				throw new ArgumentNullException();

            if (item is Person person)
				return _store.Contacts.Any(contact => contact.Person.Id == person.Id) && list.Contains(item);
			else if (item is Address address)
				return _store.Contacts.Any(contact => contact.Address.Id == address.Id) && list.Contains(item);
			else if (item is Phone phone)
				return _store.Contacts.Any(contact => contact.Phone.Id == phone.Id) && list.Contains(item);
			else
				throw new ArgumentException("Invalid type" + nameof(item));
		}

		private void contactsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
				contactsDataGridView.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
			{
				switch (e.ColumnIndex)
				{
					case 0: // person column
						OpenPersonListForm();
						break;
					case 1: // address column
						OpenAddressListForm();
						break;
					case 2: // phone column
						OpenPhoneListForm();
						break;
					case 3: // email column
						OpenEmailForm();
						break;
					default:
						break;
				}
			}
		}
	}
}