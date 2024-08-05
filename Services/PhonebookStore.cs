using System.ComponentModel;
using System.Xml.Serialization;
using WF_Phonebook.Models;

namespace WF_Phonebook.Services
{
	[XmlRoot("PhonebookStore")]
	public sealed class PhonebookStore
	{
		[XmlArray("Contacts")]
		[XmlArrayItem("Contact")]
		public BindingList<Contact> Contacts { get; set; } = new BindingList<Contact>();

		[XmlArray("Persons")]
		[XmlArrayItem("Person")]
		public BindingList<Person> Persons { get; set; } =  new BindingList<Person>();

		[XmlArray("Addresses")]
		[XmlArrayItem("Address")]
		public BindingList<Address> Addresses { get; set; } = new BindingList<Address>();

		[XmlArray("Phones")]
		[XmlArrayItem("Phone")]
		public BindingList<Phone> Phones { get; set; } = new BindingList<Phone>();

		public PhonebookStore() { }
		public PhonebookStore(BindingList<Contact> contacts, BindingList<Person> persons,
			BindingList<Address> addresses, BindingList<Phone> phones)
		{
			Contacts = contacts;
			Persons = persons;
			Addresses = addresses;
			Phones = phones;
		}
	}
}