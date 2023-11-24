using System;

namespace WF_Phonebook.Models
{
	public class Contact
	{
		private Person _person;
		private Address _address;
		private Phone _phone;
		private string _email;

		/// <summary>
		/// Person properties.
		/// </summary>
		public string PersonFirstName
		{
			get { return _person.FirstName; }
			set { _person.FirstName = value; }
		}
		public string PersonSecondName
		{
			get { return _person.LastName; }
			set { _person.LastName = value; }
		}
		public string PersonGender
		{
			get { return _person.Gender; }
			set { _person.Gender = value; }
		}
		public DateTime PersonBirthDate
		{
			get { return _person.BirthDate; }
			set { _person.BirthDate = value; }
		}

		/// <summary>
		/// Address properties.
		/// </summary>
		public string AddressStreet
		{
			get { return _address.Street; }
			set { _address.Street = value; }
		}
		public int AddressHouseNo
		{
			get { return _address.HouseNo; }
			set { _address.HouseNo = value; }
		}
		public int AddressApartmentNo
		{
			get { return _address.ApartmentNo; }
			set { _address.ApartmentNo = value; }
		}

		/// <summary>
		/// Phone properties.
		/// </summary>
		public string PhoneNumber
		{
			get { return _phone.Number; }
			set { _phone.Number = value; }
		}
		public string PhoneType
		{
			get { return _phone.Type; }
			set { _phone.Type = value; }
		}

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		/// <summary>
		/// Empty constructor is for XML Deserialization.
		/// </summary>
        public Contact()
		{
			_person = new Person();
			_address = new Address();
			_phone = new Phone();
			_email = string.Empty;
		}
        public Contact(Person person, Address address, Phone phone, string email)
		{
			_person = person;
			_address = address;
			_phone = phone;
			_email = email;
		}

		/// <summary>
		/// Updates properties of Contact.
		/// </summary>
		public void UpdateContact(Person person, Address address, Phone phone, string email)
		{
			PersonFirstName = person.FirstName;
			PersonSecondName = person.LastName;
			PersonGender = person.Gender;
			PersonBirthDate = person.BirthDate.Date;
			AddressStreet = address.Street;
			AddressHouseNo = address.HouseNo;
			AddressApartmentNo = address.ApartmentNo;
			PhoneNumber = phone.Number;
			PhoneType = phone.Type;
			Email = email;
		}

		/// <summary>
		/// Methods to get a certain type of certain data.
		/// </summary>
		public Person GetPerson()
		{
			return _person;
		}
		public Address GetAddress()
		{
			return _address;
		}
		public Phone GetPhone()
		{
			return _phone;
		}
	}
}