using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Contact
	{
		public int PersonId { get; set; }
		public int AddressId { get; set; }
		public int PhoneId { get; set; }
		public string Email { get; set; }

		[XmlIgnore]
		public Person Person { get; set; }
		[XmlIgnore]
		public Address Address { get; set; }
		[XmlIgnore]
		public Phone Phone { get; set; }

		public Contact() { }
		public Contact(Person person, Address address, Phone phone, string email)
		{
			Person = person;
			Address = address;
			Phone = phone;
			Email = email;

			PersonId = person.Id;
			AddressId = address.Id;
			PhoneId = phone.Id;
		}
	}
}