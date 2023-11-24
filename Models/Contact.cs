namespace WF_Phonebook.Models
{
	public class Contact
	{
		public int Id { get; set; }
		public Person Person { get; set; }
		public Address Address { get; set; }
		public Phone Phone { get; set; }
		public string Email { get; set; }

        public Contact()
		{
			Person = new Person();
			Address = new Address();
			Phone = new Phone();
			Email = string.Empty;
		}
        public Contact(int id, Person person, Address address, Phone phone, string email)
		{
			Id = id;
			Person = person;
			Address = address;
			Phone = phone;
			Email = email;
		}

		public Person GetPerson()
		{
			return Person;
		}
		public Address GetAddress()
		{
			return Address;
		}
		public Phone GetPhone()
		{
			return Phone;
		}
	}
}