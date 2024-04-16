using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormContact : Form
	{
		public Mode CurrentMode { get; }

		public static BindingList<Contact> Contacts { get; private set; }
		public BindingList<Person> Persons { get; }
		public BindingList<Address> Addresses { get; }
		public BindingList<Phone> Phones { get; }

		public Person Person { get; private set; }
		public Address Address { get; private set; }
		public Phone Phone { get; private set; }

		public Contact CurrentContact { get; }

		public FormContact(Mode mode, ref Store store, Contact contact = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			Contacts = store.Contacts;
			Persons = store.Persons;
			Addresses = store.Addresses;
			Phones = store.Phones;
			CurrentContact = contact;
		}

		private void FormContact_Load(object sender, EventArgs e)
			=> InitComponents();

		private void InitComponents()
		{
			if (CurrentContact != null && CurrentMode is Mode.Edit)
			{
				Person = CurrentContact.Person;
				Address = CurrentContact.Address;
				Phone = CurrentContact.Phone;
				tbEmail.Text = CurrentContact.Email;

				formContactBindingSource.DataSource = CurrentContact;
			}
		}

		private void btnPersonInfo_Click(object sender, EventArgs e)
		{
			FormPersonList form = new FormPersonList(Persons);
			if (form.ShowDialog() != DialogResult.OK)
				return;

			Person = form.CurrentPerson;
			string personInfo = Person != null ? Person.ToString() : string.Empty;
			UpdateTextBox("tbPerson", personInfo);
		}

		private void btnAddressInfo_Click(object sender, EventArgs e)
		{
			FormAddressList form = new FormAddressList(Addresses);

			if (form.ShowDialog() != DialogResult.OK)
				return;

			Address = form.CurrentAddress;
			string addressInfo = Address != null ? Address.ToString() : string.Empty;
			UpdateTextBox("tbAddress", addressInfo);
		}

		private void btnPhoneInfo_Click(object sender, EventArgs e)
		{
			FormPhoneList form = new FormPhoneList(Phones);

			if (form.ShowDialog() != DialogResult.OK)
				return;

			Phone = form.CurrentPhone;
			string phoneInfo = Phone != null ? Phone.ToString() : string.Empty; 
			UpdateTextBox("tbPhone", phoneInfo);
		}

		private void btnPersonRemove_Click(object sender, EventArgs e)
			=> RemoveItem(() => Person = null, "tbPerson");

		private void btnAddressRemove_Click(object sender, EventArgs e)
			=> RemoveItem(() => Address = null, "tbAddress");

		private void btnPhoneRemove_Click(object sender, EventArgs e)
			=> RemoveItem(() => Phone = null, "tbPhone");

		private void RemoveItem(Action removeAction, string textBoxName)
		{
			removeAction();
			UpdateTextBox(textBoxName, string.Empty);
		}

		private void UpdateTextBox(string textBoxName, string text)
		{
			if (Controls.Find(textBoxName, true).FirstOrDefault() is TextBox textBox)   // Get textBoxes by their name.
				textBox.Text = text;
		}

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

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbPerson.Text) || string.IsNullOrEmpty(tbAddress.Text)
				|| string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbEmail.Text))
			{
				MessageBox.Show("Some fields are empty! Please complete them to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Contact newContact = new Contact(Person, Address, Phone, tbEmail.Text);

			switch (CurrentMode)
			{
				case Mode.Add:
					Contacts.Add(newContact);
					break;
				case Mode.Edit:
					Contacts[Contacts.IndexOf(CurrentContact)] = newContact;
					break;
				default:
					break;
			}
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("The contact is not saved! Are you sure to cancel?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;
			Close();
		}

		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			if (sender is TextBox textBox)
			{
				textBox.Text = textBox.Text.ToLower();  // Convert text to lowercase.
				textBox.SelectionStart = textBox.Text.Length;   // Place the cursor at the end of the text.
			}
		}
	}
}