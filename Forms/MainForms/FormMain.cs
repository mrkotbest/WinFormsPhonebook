using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using WF_Phonebook.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook
{
	public partial class FormMain : Form
	{
		public BindingList<Contact> Contacts { get; set; } = new BindingList<Contact>();
		public BindingList<Person> Persons { get; set; } = new BindingList<Person>();
		public BindingList<Address> Addresses { get; set; } = new BindingList<Address>();
		public BindingList<Phone> Phones { get; set; } = new BindingList<Phone>();

		public FormMain() => InitializeComponent();

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveData();
			MessageBox.Show("Contacts are saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormContact formContact = new FormContact(Mode.Add, Contacts, Persons, Addresses, Phones);
			formContact.ShowDialog();
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedContactIndex = GetSelectedContactIndex();
			Contact selectedContact = GetSelectedContact();

			if (selectedContact != null)
			{
				FormContact formContact = new FormContact(Mode.Edit, Contacts, Persons, Addresses, Phones, selectedContact, selectedContactIndex);
				formContact.ShowDialog();
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			RemoveItem();
		}

		private void LoadData()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Store));

			if (File.Exists("contacts.xml") && new FileInfo("contacts.xml").Length > 0)
			{
				using (FileStream fs = new FileStream("contacts.xml", FileMode.OpenOrCreate))
				{
					Store store = (Store)formatter.Deserialize(fs);
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
		private void SaveData()
		{
			try
			{
				Store store = new Store(Contacts, Persons, Addresses, Phones);

				XmlSerializer formatter = new XmlSerializer(typeof(Store));

				using (FileStream fs = new FileStream("contacts.xml", FileMode.Create))
				{
					formatter.Serialize(fs, store);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RemoveItem()
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Are you sure to remove this record?", "Removal warning",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int selectedRowIndex = GetSelectedContactIndex();
					Contacts.RemoveAt(selectedRowIndex);
				}
			}
		}
		private int GetSelectedContactIndex() => contactsDataGridView.SelectedRows.Count > 0 ? contactsDataGridView.SelectedRows[0].Index : -1;
		private Contact GetSelectedContact()
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = GetSelectedContactIndex();
				return Contacts[selectedRowIndex];
			}
			return null;
		}

		private void InitializeControls()
		{
			LoadData();
			contactsBindingSource.DataSource = Contacts;
			
			Contacts.ListChanged += Contacts_ListChanged;
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}

		private void Contacts_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			InitializeControls();
		}
		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}
	}
}