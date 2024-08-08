using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Forms.AddressForms;
using WF_Phonebook.Forms.PersonForms;
using WF_Phonebook.Forms.PhoneForms;
using WF_Phonebook.Models;
using WF_Phonebook.Services;

namespace WF_Phonebook.Forms.MainForms
{
	public partial class ContactForm : Form
	{
		public BindingList<Person> Persons { get; }
		public BindingList<Address> Addresses { get; }
		public BindingList<Phone> Phones { get; }

		public Person Person { get; private set; }
		public Address Address { get; private set; }
		public Phone Phone { get; private set; }

		public Contact CreatedNewContact { get; private set; }

		public ContactForm(PhonebookStore store)
		{
			InitializeComponent();

			Persons = store.Persons;
			Addresses = store.Addresses;
			Phones = store.Phones;
		}

		private void btnPersonInfo_Click(object sender, EventArgs e)
		{
			using (var form = new PersonListForm(Persons))
			{
				if (form.ShowDialog() != DialogResult.OK)
				{
					RemoveItemAndUpdateTextBox(() => Person = null, nameof(tbPerson));
					return;
				}
				Person = form.CurrentPerson;
				string personInfo = Person != null ? Person.ToString() : string.Empty;
				UpdateTextBox(nameof(tbPerson), personInfo);
			}
		}

		private void btnAddressInfo_Click(object sender, EventArgs e)
		{
			using (var form = new AddressListForm(Addresses))
			{
				if (form.ShowDialog() != DialogResult.OK)
				{
					RemoveItemAndUpdateTextBox(() => Address = null, nameof(tbAddress));
					return;
				}
				Address = form.CurrentAddress;
				string addressInfo = Address != null ? Address.ToString() : string.Empty;
				UpdateTextBox(nameof(tbAddress), addressInfo);
			}
		}

		private void btnPhoneInfo_Click(object sender, EventArgs e)
		{
			using (var form = new PhoneListForm(Phones))
			{
				if (form.ShowDialog() != DialogResult.OK)
				{
					RemoveItemAndUpdateTextBox(() => Phone = null, nameof(tbPhone));
					return;
				}
				Phone = form.CurrentPhone;
				string phoneInfo = Phone != null ? Phone.ToString() : string.Empty; 
				UpdateTextBox(nameof(tbPhone), phoneInfo);
			}
		}

		private void UpdateTextBox(string textBoxName, string text)
		{
			if (Controls.Find(textBoxName, true).FirstOrDefault() is TextBox textBox)   // Get textBoxes by their name.
				textBox.Text = text;
		}

		private void btnPersonRemove_Click(object sender, EventArgs e)
			=> RemoveItemAndUpdateTextBox(() => Person = null, nameof(tbPerson));

		private void btnAddressRemove_Click(object sender, EventArgs e)
			=> RemoveItemAndUpdateTextBox(() => Address = null, nameof(tbAddress));

		private void btnPhoneRemove_Click(object sender, EventArgs e)
			=> RemoveItemAndUpdateTextBox(() => Phone = null, nameof(tbPhone));

		private void RemoveItemAndUpdateTextBox(Action removeAction, string textBoxName)
		{
			removeAction();
			UpdateTextBox(textBoxName, string.Empty);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (!ValidateField(tbPerson, "Person field is empty! Please complete it to add new contact.") ||
				!ValidateField(tbAddress, "Address field is empty! Please complete it to add new contact.") ||
				!ValidateField(tbPhone, "Phone field is empty! Please complete it to add new contact.") ||
				!ValidateField(tbEmail, "Email field is empty! Please complete it to add new contact."))
				return;

			CreatedNewContact = new Contact(MainForm.GenerateNewContactId(), Person, Address, Phone, tbEmail.Text);
			DialogResult = DialogResult.OK;
			Close();
		}

		private bool ValidateField(TextBox field, string errorMessage)
		{
			if (string.IsNullOrEmpty(field.Text))
			{
				MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("The contact is not saved! Are you sure to cancel?", "Removal warning",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
				return;
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}