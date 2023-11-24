using System;

namespace WF_Phonebook.Models
{
	public class Person
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public DateTime BirthDate { get; set; }

		public Person() { }
		public Person(string firstName, string lastName, string gender, DateTime birthDate)
		{
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			BirthDate = birthDate;
		}

		public override string ToString() => $"{FirstName} {LastName} [{Gender}] {BirthDate.Date.ToShortDateString()}";
	}
}