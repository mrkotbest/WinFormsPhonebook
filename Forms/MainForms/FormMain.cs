using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using WF_Phonebook.Forms;
using WF_Phonebook.Forms.EmailForms;
using WF_Phonebook.Models;

namespace WF_Phonebook
{
	public partial class FormMain : Form
	{
		private const string _xmlFileName = "contacts.xml";

		public static BindingList<Contact> Contacts { get; set; }
		public BindingList<Person> Persons { get; set; }
		public BindingList<Address> Addresses { get; set; }
		public BindingList<Phone> Phones { get; set; }
		public Email Email { get; set; }

		public Contact CurrentContact { get; set; }

		public FormMain()
			=> InitializeComponent();

		private void FormMain_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			Contacts = new BindingList<Contact>();
			Persons = new BindingList<Person>();
			Addresses = new BindingList<Address>();
			Phones = new BindingList<Phone>();
			Email = new Email();

			LoadData();

			contactsBindingSource.DataSource = Contacts;

			Contacts.ListChanged += HandleListChanged;
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}

		private void HandleListChanged(object sender, ListChangedEventArgs e)
			=> btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;

		private void LoadData()
		{
			if (File.Exists(_xmlFileName) && new FileInfo(_xmlFileName).Length > 0)
			{
				try
				{
					using (FileStream fs = new FileStream(_xmlFileName, FileMode.OpenOrCreate))
					{
						XmlSerializer formatter = new XmlSerializer(typeof(Store));

						if (formatter.Deserialize(fs) is Store store)
						{
							Persons = store.Persons;
							Addresses = store.Addresses;
							Phones = store.Phones;

							var personsDict = Persons.ToDictionary(p => p.Id);
							var addressesDict = Addresses.ToDictionary(a => a.Id);
							var phonesDict = Phones.ToDictionary(p => p.Id);

							foreach (Contact contact in store.Contacts)
							{
								if (personsDict.TryGetValue(contact.PersonId, out Person person) &&
									addressesDict.TryGetValue(contact.AddressId, out Address address) &&
									phonesDict.TryGetValue(contact.PhoneId, out Phone phone))
								{
									Contacts.Add(new Contact(person, address, phone, contact.Email));
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					File.AppendAllText("error.log", $"[{DateTime.Now}] An error occurred while loading data: {ex.Message}\n");
					MessageBox.Show("An error occurred while loading..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private bool SaveData()
		{
			try
			{
				var store = new Store(Contacts, Persons, Addresses, Phones);
				XmlSerializer formatter = new XmlSerializer(typeof(Store));

				using (FileStream fs = new FileStream(_xmlFileName, FileMode.Create))
				{
					formatter.Serialize(fs, store);
				}
				return true;
			}
			catch (Exception ex)
			{
				File.AppendAllText("error.log", $"[{DateTime.Now}] An error occurred while saving data: {ex.Message}\n");
				MessageBox.Show("An error occurred while saving..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (SaveData())
				MessageBox.Show("Contacts are saved!\n\n(Saving occurs automatically when you exit the application)", "Success",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Store store = new Store(Contacts, Persons, Addresses, Phones);
			FormContact formContact = new FormContact(ref store);
			formContact.ShowDialog();
		}

		private void tsPersonItem_Click(object sender, EventArgs e)
		{
			FormPersonList form = new FormPersonList(Persons);
			if (form.ShowDialog() == DialogResult.OK)
			{
				RefreshCurrentContactFromDGV();

				var person = form.CurrentPerson;
				Contacts[contactsDataGridView.SelectedRows[0].Index].Person = person;
				Contacts[contactsDataGridView.SelectedRows[0].Index].PersonId = person.Id;
			}
			contactsDataGridView.Refresh();
		}

		private void tsAddressItem_Click(object sender, EventArgs e)
		{
			FormAddressList form = new FormAddressList(Addresses);
			if (form.ShowDialog() == DialogResult.OK)
			{
				RefreshCurrentContactFromDGV();

				var address = form.CurrentAddress;
				Contacts[contactsDataGridView.SelectedRows[0].Index].Address = address;
				Contacts[contactsDataGridView.SelectedRows[0].Index].AddressId = address.Id;
			}
			contactsDataGridView.Refresh();
		}

		private void tsPhoneItem_Click(object sender, EventArgs e)
		{
			FormPhoneList form = new FormPhoneList(Phones);
			if (form.ShowDialog() == DialogResult.OK)
			{
				RefreshCurrentContactFromDGV();

				var phone = form.CurrentPhone;
				Contacts[contactsDataGridView.SelectedRows[0].Index].Phone = phone;
				Contacts[contactsDataGridView.SelectedRows[0].Index].PhoneId = phone.Id;
			}
			contactsDataGridView.Refresh();
		}

		private void tsEmailItem_Click(object sender, EventArgs e)
		{
			RefreshCurrentContactFromDGV();
			Email.EmailStr = CurrentContact.Email;

			FormEmail form = new FormEmail(Email);
			if (form.ShowDialog() == DialogResult.OK)
			{
				var email = form.Email;
				Contacts[contactsDataGridView.SelectedRows[0].Index].Email = email.EmailStr;
			}
			contactsDataGridView.Refresh();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Are you sure to remove this record?", "Removal warning",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Contacts.RemoveAt(contactsDataGridView.SelectedRows[0].Index);
				}
			}
		}

		private void contactsDataGridView_SelectionChanged(object sender, EventArgs e)
			=> RefreshCurrentContactFromDGV();

		private void RefreshCurrentContactFromDGV()
			=> CurrentContact = contactsDataGridView.SelectedRows.Count > 0 ? Contacts[contactsDataGridView.SelectedRows[0].Index] : null;

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
			=> SaveData();

		public static bool IsUsedInContacts<T>(T item)
		{
			if (item is Person person)
				return Contacts.Any(contact => contact.Person == person);
			else if (item is Address address)
				return Contacts.Any(contact => contact.Address == address);
			else if (item is Phone phone)
				return Contacts.Any(contact => contact.Phone == phone);
			else
				throw new ArgumentException("Invalid type", nameof(item));
		}
	}
}