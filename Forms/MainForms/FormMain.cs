using System;
using System.ComponentModel;
using System.IO;
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

		public FormMain()
		{
			InitializeComponent();
			InitializeControls();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveData();
			MessageBox.Show("Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			FormContact formContact = new FormContact(Mode.Add, Contacts, Persons, Addresses, Phones);

			if (formContact.ShowDialog() == DialogResult.OK)
			{
				Contacts = formContact.Contacts;
			}
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedContactIndex = GetSelectedContactIndex();
			Contact selectedContact = GetSelectedContact();
			if (selectedContact != null)
			{
				FormContact formContact = new FormContact(Mode.Edit, Contacts, Persons, Addresses, Phones, selectedContact, selectedContactIndex);
				if (formContact.ShowDialog() == DialogResult.OK)
				{
					Contacts = formContact.Contacts;
				}
			}
		}
		private void btnRemove_Click(object sender, EventArgs e)
		{
			RemoveItem();
		}
		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveData();
		}

		private void Contacts_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}

		private void InitializeControls()
		{

			LoadData();
			contactsBindingSource.DataSource = Contacts;
			
			Contacts.ListChanged += Contacts_ListChanged;
			btnEdit.Enabled = Contacts.Count > 0;
			btnRemove.Enabled = Contacts.Count > 0;
		}

		private int GetSelectedContactIndex()
		{
			return contactsDataGridView.SelectedRows[0].Index;
		}
		private Contact GetSelectedContact()
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = GetSelectedContactIndex();
				return Contacts[selectedRowIndex];
			}
			return null;
		}
		private void RemoveItem()
		{
			if (Contacts.Count == 0 || Contacts is null)
			{
				MessageBox.Show("There is no item to remove.", "Removal warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (contactsDataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Are you sure to remove this record?", "Removal warning",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					int selectedRowIndex = GetSelectedContactIndex();
					Contacts.RemoveAt(selectedRowIndex);
				}
			}
		}

		private void LoadData()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Contact>));

			if (File.Exists("contacts.xml") && new FileInfo("contacts.xml").Length > 0)
			{
				using (FileStream fs = new FileStream("contacts.xml", FileMode.OpenOrCreate))
				{
					Contacts = (BindingList<Contact>)formatter.Deserialize(fs);
				}

				foreach (Contact contact in Contacts)
				{
					Persons.Add(contact.GetPerson());
					Addresses.Add(contact.GetAddress());
					Phones.Add(contact.GetPhone());
				}
			}
		}
		private void SaveData()
		{
			XmlSerializer formatter = new XmlSerializer(typeof(BindingList<Contact>));

			using (FileStream fs = new FileStream("contacts.xml", FileMode.Create))
			{
				formatter.Serialize(fs, Contacts);
			}
		}
		//private void InitTestData()
		//{
		//	Contacts.Add(new Contact(
		//		Contacts.Count,
		//		new Person("Jessica", "ARCANGULA", "female", DateTime.UtcNow),
		//		new Address("JSSTREET", 23, 2334),
		//		new Phone("+380686312365", "mobile"),
		//		"js@gmail.com"));
		//	Contacts.Add(new Contact(
		//		Contacts.Count,
		//		new Person("Jessica", "ARCANGULA", "female", DateTime.UtcNow),
		//		new Address("JSSTREET", 23, 2334),
		//		new Phone("+380686312365", "mobile"),
		//		"js@gmail.com"));
		//	Contacts.Add(new Contact(
		//		Contacts.Count,
		//		new Person("Jessica", "ARCANGULA", "female", DateTime.UtcNow),
		//		new Address("JSSTREET", 23, 2334),
		//		new Phone("+380686312365", "mobile"),
		//		"js@gmail.com"));
		//}
	}
}