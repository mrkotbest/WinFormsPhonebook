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
		private const string _xmlFileName = "contacts.xml";

		public BindingList<Contact> Contacts { get; set; } = new BindingList<Contact>();
		public BindingList<Person> Persons { get; set; } = new BindingList<Person>();
		public BindingList<Address> Addresses { get; set; } = new BindingList<Address>();
		public BindingList<Phone> Phones { get; set; } = new BindingList<Phone>();

		public Contact CurrentContact { get; set; }

		public FormMain()
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

		private void HandleListChanged(object sender, ListChangedEventArgs e)
			=> btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;

		private void LoadData()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(Store));

			if (File.Exists(_xmlFileName) && new FileInfo(_xmlFileName).Length > 0)
			{
				using (FileStream fs = new FileStream(_xmlFileName, FileMode.OpenOrCreate))
				{
					try
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
					catch (Exception ex)
					{
						File.AppendAllText("error.log", $"[{DateTime.Now}] An error occurred while loading data: {ex.Message}\n");
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

				using (FileStream fs = new FileStream(_xmlFileName, FileMode.Create))
				{
					formatter.Serialize(fs, store);
				}
			}
			catch (Exception ex)
			{
				File.AppendAllText("error.log", $"[{DateTime.Now}] An error occurred while saving data: {ex.Message}\n");
			}
		}

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
			if (CurrentContact != null)
			{
				FormContact formContact = new FormContact(Mode.Edit, Contacts, Persons, Addresses, Phones, CurrentContact);
				formContact.ShowDialog();
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
				}
			}
		}

		private void contactsDataGridView_SelectionChanged(object sender, EventArgs e)
			=> CurrentContact = contactsDataGridView.SelectedRows.Count > 0 ? Contacts[contactsDataGridView.SelectedRows[0].Index] : null;

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
			=> SaveData();
	}
}