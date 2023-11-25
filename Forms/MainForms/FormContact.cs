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

		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Person> Persons { get; set; }
		public BindingList<Address> Addresses { get; set; }
		public BindingList<Phone> Phones { get; set; }

		public Person Person { get; set; }
		public Address Address { get; set; }
		public Phone Phone { get; set; }

		public int CurrentContactIndex { get; set; }
		public Contact CurrentContact { get; set; }

		public FormContact(Mode mode, BindingList<Contact> contacts,
			BindingList<Person> persons, BindingList<Address> addresses, BindingList<Phone> phones,
			Contact contact = null, int contactIndex = 0)
		{
			InitializeComponent();

			CurrentMode = mode;
			Contacts = contacts;
			Persons = persons;
			Addresses = addresses;
			Phones = phones;
			CurrentContact = contact;
			CurrentContactIndex = contactIndex;

			InitializeControls();
		}

		private void InitializeControls()
		{
			if (CurrentMode == Mode.Edit)
			{
				tbPerson.Text = CurrentContact.GetPerson().ToString();
				tbAddress.Text = CurrentContact.GetAddress().ToString();
				tbPhone.Text = CurrentContact.GetPhone().ToString();
				tbEmail.Text = CurrentContact.Email;
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
			if (CurrentMode == Mode.Add)
			{
				FormPersonList formPersonList = new FormPersonList(Persons);
				if (formPersonList.ShowDialog() == DialogResult.OK)
				{
					Person = formPersonList.Persons[formPersonList.GetSelectedPersonIndex()];
				}
			}
			else if (CurrentMode == Mode.Edit && CurrentContact != null)
			{
				FormPersonData formPersonData = new FormPersonData(CurrentMode, CurrentContact.GetPerson());
				formPersonData.ShowDialog();
				Person = formPersonData.Person;
			}
			if (Person is null) return;
			UpdateTextBox("tbPerson", Person.ToString());
		}
		private void btnAddressInfo_Click(object sender, EventArgs e)
		{
			if (CurrentMode == Mode.Add)
			{
				FormAddressList formAddressList = new FormAddressList(Addresses);
				if (formAddressList.ShowDialog() == DialogResult.OK)
				{
					Address = formAddressList.Addresses[formAddressList.GetSelectedAddressIndex()];
				}
			}
			else if (CurrentMode == Mode.Edit)
			{
				FormAddressData formAddressData = new FormAddressData(CurrentMode, CurrentContact.GetAddress());
				formAddressData.ShowDialog();
				Address = formAddressData.Address;
			}
			if (Address is null) return;
			UpdateTextBox("tbAddress", Address.ToString());
		}
		private void btnPhoneInfo_Click(object sender, EventArgs e)
		{
			if (CurrentMode == Mode.Add)
			{
				FormPhoneList formPhoneList = new FormPhoneList(Phones);
				if (formPhoneList.ShowDialog() == DialogResult.OK)
				{
					Phone = formPhoneList.Phones[formPhoneList.GetSelectedPhoneIndex()];
				}
			}
			else if (CurrentMode == Mode.Edit)
			{
				FormPhoneData formPhoneData = new FormPhoneData(CurrentMode, CurrentContact.GetPhone());
				formPhoneData.ShowDialog();
				Phone = formPhoneData.Phone;
			}
			if (Phone is null) return;
			UpdateTextBox("tbPhone", Phone.ToString());
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
			if (tbPerson.Text == string.Empty || tbAddress.Text == string.Empty || tbPhone.Text == string.Empty || tbEmail.Text == string.Empty)
			{
				MessageBox.Show("Some fields are empty! Please complete them to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Person = Person ?? CurrentContact.GetPerson();
			Address = Address ?? CurrentContact.GetAddress();
			Phone = Phone ?? CurrentContact.GetPhone();

			Contact newContact = new Contact(id: Contacts.Count, Person, Address, Phone, tbEmail.Text);

			if (CurrentMode == Mode.Add)
			{
				Contacts.Add(newContact);
			}
			else if (CurrentMode == Mode.Edit)
			{
				Contacts[CurrentContactIndex] = newContact;
			}

			DialogResult = DialogResult.OK;
			Close();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("The contact is not saved! Are you sure to cancel?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
		private void tbEmail_Validating(object sender, CancelEventArgs e)
		{
			if (sender is TextBox textBox)
			{
				// Checking for the '@' symbol and the ending ".com".
				if (!textBox.Text.Contains("@") || !textBox.Text.EndsWith(".com"))
				{
					MessageBox.Show("Please enter a valid email address!", "Warning",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					e.Cancel = true;
				}

			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (MessageBox.Show("The contact is not saved! Are you sure to cancel?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				if (keyData == Keys.Escape)
				{
					Close();
					return true;
				}
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}