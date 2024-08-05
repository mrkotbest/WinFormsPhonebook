using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public sealed class Contact
	{
		[XmlAttribute("Id")]
		public int ContactId { get; set; }
		public Person Person { get; set; }
		public Address Address { get; set; }
		public Phone Phone { get; set; }
		public string Email { get; set; }

		public Contact() { }
		public Contact(int id, Person person, Address address, Phone phone, string email)
		{
			ContactId = id; 
			Person = person;
			Address = address;
			Phone = phone;
			Email = email;
		}
	}
}