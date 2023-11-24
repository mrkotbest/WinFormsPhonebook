using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormContact : Form
	{
		public Mode CurrentMode { get; set; }
		public FormMain FormMain { get; set; }

		public BindingList<Contact> Contacts { get; }
		public BindingList<Person> PersonList { get; set; } = new BindingList<Person>();
		public BindingList<Address> AddressList { get; set; } = new BindingList<Address>();
		public BindingList<Phone> PhoneList { get; set; } = new BindingList<Phone>();


		public Contact CurrentContact { get; set; }
		public Person SelectedPerson { get; set; }
		public Address SelectedAddress { get; set; }
		public Phone SelectedPhone { get; set; }

		public FormContact(FormMain formMain, BindingList<Contact> contacts, Mode mode, Contact contact = null)
		{
			InitializeComponent();

			FormMain = formMain;
			Contacts = contacts;
			CurrentMode = mode;
			CurrentContact = contact;

			if (CurrentMode == Mode.Edit)
			{
				SelectedPerson = CurrentContact.GetPerson();
				SelectedAddress = CurrentContact.GetAddress();
				SelectedPhone = CurrentContact.GetPhone();

				tbPerson.Text = SelectedPerson.ToString();
				tbAddress.Text = SelectedAddress.ToString();
				tbPhone.Text = SelectedPhone.ToString();
				tbEmail.Text = CurrentContact.Email;
			}
		}

		private void ClearTextBox(TextBox textBox)
		{
			textBox.Clear();
		}
		public void UpdateTextBox(string textBoxName, string text)
		{
			// Get textBoxes by their name.
			if (Controls.Find(textBoxName, true).FirstOrDefault() is TextBox textBox)
			{
				textBox.Text = text;
			}
		}
		private void RemoveDataByType<T>(TextBox textBox) where T : class
		{
			if (MessageBox.Show($"{typeof(T).Name} data is going to be cleaned!", "Removal warning",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				ClearTextBox(textBox);
				if (typeof(T) == typeof(Person)) SelectedPerson = null;
				else if (typeof(T) == typeof(Address)) SelectedAddress = null;
				else if (typeof(T) == typeof(Phone)) SelectedPhone = null;
			}
		}

		private void btnPersonInfo_Click(object sender, EventArgs e)
		{
			if (CurrentMode == Mode.Add)
			{
				FormPersonList formPersonList = new FormPersonList(this, Contacts, PersonList, CurrentMode);
				formPersonList.ShowDialog();
			}
			else if (CurrentMode == Mode.Edit)
			{
				FormPersonData formPersonData = new FormPersonData(this, PersonList, CurrentMode, CurrentContact.GetPerson());
				formPersonData.ShowDialog();
				UpdateTextBox("tbPerson", SelectedPerson.ToString());
			}
		}
		private void btnAddressInfo_Click(object sender, EventArgs e)
		{
			FormAddressList formAddressList = new FormAddressList(this, Contacts, AddressList, CurrentMode);
			formAddressList.ShowDialog();
		}
		private void btnPhoneInfo_Click(object sender, EventArgs e)
		{
			FormPhoneList formPhoneList = new FormPhoneList(this, Contacts, PhoneList, CurrentMode);
			formPhoneList.ShowDialog();
		}

		private void btnPersonRemove_Click(object sender, EventArgs e)
		{
			RemoveDataByType<Person>(tbPerson);
		}
		private void btnAddressRemove_Click(object sender, EventArgs e)
		{
			RemoveDataByType<Address>(tbAddress);
		}
		private void btnPhoneRemove_Click(object sender, EventArgs e)
		{
			RemoveDataByType<Phone>(tbPhone);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			TextBox[] textBoxes = new[] { tbPerson, tbAddress, tbPhone, tbEmail };
			if (textBoxes.Any(tb => tb.Text == string.Empty))
			{
				MessageBox.Show("There is no data in some field!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (CurrentMode == Mode.Add && (SelectedPerson != null & SelectedAddress != null & SelectedPhone != null))
			{
				Contacts.Add(new Contact(SelectedPerson, SelectedAddress, SelectedPhone, tbEmail.Text));
			}
			else if (CurrentMode == Mode.Edit)
			{
				CurrentContact.UpdateContact(SelectedPerson, SelectedAddress, SelectedPhone, tbEmail.Text);
			}
			Close();
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (SelectedPerson != null || SelectedAddress != null || SelectedPhone != null || tbEmail.Text != string.Empty)
			{
				if (MessageBox.Show("You are going to remove the Contact data!", "Removal warning",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
					return;
				else
				{
					SelectedPerson = null;
					SelectedAddress = null;
					SelectedPhone = null;
				}
			}
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
	}
}