using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public sealed class Contact
	{
		[XmlAttribute("PersonId")]
		public int PersonId { get; set; }
		[XmlAttribute("AddressId")]
		public int AddressId { get; set; }
		[XmlAttribute("PhoneId")]
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