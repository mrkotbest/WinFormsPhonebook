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

		private PhonebookStore _store;

		public static BindingList<Contact> Contacts { get; set; } = new BindingList<Contact>();
		public static Contact CurrentContact { get; private set; }

		public BindingList<Person> Persons { get; set; }
		public BindingList<Address> Addresses { get; set; }
		public BindingList<Phone> Phones { get; set; }
		public string Email { get; private set; }

		public MainForm()
			=> InitializeComponent();

		private void FormMain_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			LoadData();

			contactsBindingSource.DataSource = Contacts;

			Contacts.ListChanged += HandleListChanged;
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}

		private void InitLists(PhonebookStore store)
		{
			Contacts = store.Contacts;
			Persons = store.Persons;
			Addresses = store.Addresses;
			Phones = store.Phones;
		}

		private void HandleListChanged(object sender, ListChangedEventArgs e)
			=> btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;

		private void LoadData()
		{
			if (!File.Exists(_xmlFileName) || new FileInfo(_xmlFileName).Length == 0)
			{
				_store = new PhonebookStore();
				InitLists(_store);
				return;
			}

			try
			{
				using (var fs = new FileStream(_xmlFileName, FileMode.OpenOrCreate))
				{
					var formatter = new XmlSerializer(typeof(PhonebookStore));
					var store = formatter.Deserialize(fs) as PhonebookStore;

					if (store is null)
						return;

					_store = new PhonebookStore(store.Contacts, store.Persons, store.Addresses, store.Phones);
					InitLists(_store);
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
					MessageBox.Show("An error occurred while loading..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private bool SaveData()
		{
			try
			{
				var store = new PhonebookStore(_store.Contacts, _store.Persons, _store.Addresses, _store.Phones);
				var formatter = new XmlSerializer(typeof(PhonebookStore));

				using (FileStream fs = new FileStream(_xmlFileName, FileMode.Create))
				{
					formatter.Serialize(fs, store);
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
			using (var form = new ContactForm(ref _store))
			{
				form.ShowDialog();
			}
		}

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
			using (var form = new PersonListForm(Persons))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					var person = form.CurrentPerson;
					Contacts[contactsDataGridView.SelectedRows[0].Index].Person = person;
				}
				contactsDataGridView.Refresh();
			}
		}

		private void OpenAddressListForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new AddressListForm(Addresses))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					var address = form.CurrentAddress;
					Contacts[contactsDataGridView.SelectedRows[0].Index].Address = address;
				}
				contactsDataGridView.Refresh();
			}
		}

		private void OpenPhoneListForm()
		{
			RefreshCurrentContactFromDGV();
			using (var form = new PhoneListForm(Phones))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					var phone = form.CurrentPhone;
					Contacts[contactsDataGridView.SelectedRows[0].Index].Phone = phone;
				}
				contactsDataGridView.Refresh();
			}
		}

		private void OpenEmailForm()
		{
			RefreshCurrentContactFromDGV();
			Email = CurrentContact.Email;

			using (var form = new EmailForm(Email))
			{
				if (form.ShowDialog() == DialogResult.OK)
					Contacts[contactsDataGridView.SelectedRows[0].Index].Email = form.Email;
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
					Contacts.RemoveAt(contactsDataGridView.SelectedRows[0].Index);

					if (contactsDataGridView.Rows.Count > 0)
						contactsDataGridView.FirstDisplayedCell.Selected = true;
				}
			}
		}

		private void contactsDataGridView_SelectionChanged(object sender, EventArgs e)
			=> RefreshCurrentContactFromDGV();

		private void RefreshCurrentContactFromDGV()
			=> CurrentContact = contactsDataGridView.SelectedRows.Count > 0 ? Contacts[contactsDataGridView.SelectedRows[0].Index] : null;

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
			=> SaveData();

		public static bool IsUsedInContacts<T>(T item, BindingList<T> list) where T : class
		{
			if (item == null || list == null)
				throw new ArgumentNullException();

            if (item is Person person)
				return Contacts.Any(contact => contact.Person.Id == person.Id) && list.Contains(item);
			else if (item is Address address)
				return Contacts.Any(contact => contact.Address.Id == address.Id) && list.Contains(item);
			else if (item is Phone phone)
				return Contacts.Any(contact => contact.Phone.Id == phone.Id) && list.Contains(item);
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