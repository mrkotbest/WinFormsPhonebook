using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
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
			FormContact formContact = new FormContact(this, Contacts, Mode.Add);
			formContact.ShowDialog();

		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			Contact selectedContact = GetSelectedContact();
			if (selectedContact != null)
			{
				FormContact formContact = new FormContact(this, Contacts, Mode.Edit, selectedContact);
				formContact.ShowDialog();
				contactsDataGridView.Refresh();
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

		private void InitializeControls()
		{
			LoadData();
			
			contactsBindingSource.DataSource = Contacts;
			
			Contacts.ListChanged += Contacts_ListChanged;
			btnEdit.Enabled = Contacts.Count > 0;
			btnRemove.Enabled = Contacts.Count > 0;
		}

		private void Contacts_ListChanged(object sender, ListChangedEventArgs e)
		{
			btnEdit.Enabled = btnRemove.Enabled = Contacts.Count > 0;
		}

		private Contact GetSelectedContact()
		{
			if (contactsDataGridView.SelectedRows.Count == 1)
			{
				int selectedRowIndex = contactsDataGridView.SelectedRows[0].Index;
				return Contacts[selectedRowIndex];
			}
			return null;
		}
		private void RemoveItem()
		{
			if (Contacts.Count == 0 || Contacts is null)
			{
				MessageBox.Show("There is no item to remove.", "No Item to Remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (contactsDataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Are you sure to remove?", "Removal warning",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					int selectedRowIndex = contactsDataGridView.SelectedRows[0].Index;
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
			}
			else
			{
				InitTestData();
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
		private void InitTestData()
		{
			Contacts.Add(new Contact(
				new Person("John", "Walker", "male", DateTime.Now.Date),
				new Address("Blackmen Street", 11, 23),
				new Phone("+15874962358", "mobile"),
				"blackman@gmail.com"));
			Contacts.Add(new Contact(
				new Person("Mia", "Halifa", "female", DateTime.Now.Date),
				new Address("Oxford Square", 5, 297),
				new Phone("+448573296858", "mobile"),
				"mselizamilez@gmail.com"));
			Contacts.Add(new Contact(
				new Person("Jack", "Sparrow", "male", DateTime.Now.Date),
				new Address("The Black Pearl", 1, 1),
				new Phone("+15698741255", "mobile"),
				"sparrowcapitan@gmail.com"));
			Contacts.Add(new Contact(
				new Person("Donald", "Trump", "male", DateTime.Now.Date),
				new Address("Washington Street", 76, 158),
				new Phone("+10278549637", "mobile"),
				"trumpnextpresident@gmail.com"));
		}
	}
}