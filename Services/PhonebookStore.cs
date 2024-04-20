using System.ComponentModel;
using WF_Phonebook.Models;

namespace WF_Phonebook.Services
{
	public sealed class PhonebookStore
	{
		public BindingList<Contact> Contacts { get; set; }
		public BindingList<Person> Persons { get; set; }
		public BindingList<Address> Addresses { get; set; }
		public BindingList<Phone> Phones { get; set; }

		public PhonebookStore() { }
		public PhonebookStore(BindingList<Contact> contacts, BindingList<Person> persons, BindingList<Address> addresses, BindingList<Phone> phones)
		{
			Contacts = contacts;
			Persons = persons;
			Addresses = addresses;
			Phones = phones;
		}
	}
}