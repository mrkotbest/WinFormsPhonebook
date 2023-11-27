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

		public BindingList<Contact> Contacts { get; }
		public BindingList<Person> Persons { get; }
		public BindingList<Address> Addresses { get; }
		public BindingList<Phone> Phones { get; }

		public Person Person { get; private set; }
		public Address Address { get; private set; }
		public Phone Phone { get; private set; }

		public int CurrentContactIndex { get; }
		public Contact CurrentContact { get; }

		public FormContact(Mode mode, BindingList<Contact> contacts, BindingList<Person> persons,
			BindingList<Address> addresses, BindingList<Phone> phones, Contact contact = null, int contactIndex = 0)
		{
			InitializeComponent();

			CurrentMode = mode;
			Contacts = contacts;
			Persons = persons;
			Addresses = addresses;
			Phones = phones;
			CurrentContact = contact;
			CurrentContactIndex = contactIndex;
		}

		private void InitializeControls()
		{
			if (CurrentMode == Mode.Edit)
			{
				Person = CurrentContact.Person;
				Address = CurrentContact.Address;
				Phone = CurrentContact.Phone;
				tbEmail.Text = CurrentContact.Email;

				formContactBindingSource.DataSource = CurrentContact;
			}
		}
		private void UpdateTextBox(string textBoxName, string text)
		{
			// Get textBoxes by their name.
			if (Controls.Find(textBoxName, true).FirstOrDefault() is TextBox textBox)
			{
				textBox.Text = text;
			}
		}

		private void btnPersonInfo_Click(object sender, EventArgs e)
		{
			FormPersonList form = new FormPersonList(Persons);
			if (form.ShowDialog() == DialogResult.OK && form.SelectedPersonIndex != -1)
			{
				Person = form.Persons[form.SelectedPersonIndex];
				UpdateTextBox("tbPerson", Person.ToString());
			}
		}
		private void btnAddressInfo_Click(object sender, EventArgs e)
		{
			FormAddressList form = new FormAddressList(Addresses);
			if (form.ShowDialog() == DialogResult.OK && form.SelectedAddressIndex != -1)
			{
				Address = form.Addresses[form.SelectedAddressIndex];
				UpdateTextBox("tbAddress", Address.ToString());
			}
		}
		private void btnPhoneInfo_Click(object sender, EventArgs e)
		{
			FormPhoneList form = new FormPhoneList(Phones);
			if (form.ShowDialog() == DialogResult.OK && form.SelectedPhoneIndex != -1)
			{
				Phone = form.Phones[form.SelectedPhoneIndex];
				UpdateTextBox("tbPhone", Phone.ToString());
			}
		}

		private void btnPersonRemove_Click(object sender, EventArgs e)
		{
			UpdateTextBox("tbPerson", string.Empty);
		}
		private void btnAddressRemove_Click(object sender, EventArgs e)
		{
			UpdateTextBox("tbAddress", string.Empty);
		}
		private void btnPhoneRemove_Click(object sender, EventArgs e)
		{
			UpdateTextBox("tbPhone", string.Empty);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbPerson.Text) || string.IsNullOrEmpty(tbAddress.Text)
				|| string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(tbEmail.Text))
			{
				MessageBox.Show("Some fields are empty! Please complete them to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Person = Person ?? Persons[CurrentContactIndex];
			Address = Address ?? Addresses[CurrentContactIndex];
			Phone = Phone ?? Phones[CurrentContactIndex];

			Contact newContact = new Contact(Person, Address, Phone, tbEmail.Text);

			if (CurrentMode == Mode.Add)
			{
				Contacts.Add(newContact);
			}
			else if (CurrentMode == Mode.Edit)
			{
				Contacts[CurrentContactIndex] = newContact;
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
				// Convert text to lowercase.
				textBox.Text = textBox.Text.ToLower();

				// Place the cursor at the end of the text.
				textBox.SelectionStart = textBox.Text.Length;
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// Closes the form by pressing 'Escape'.
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void FormContact_Load(object sender, EventArgs e)
		{
			InitializeControls();
		}
	}
}