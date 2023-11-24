using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace WF_Phonebook.Models
{
	public class Person
	{
		[Browsable(true)]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[Browsable(true)]
		public string Gender { get; set; }
		[Browsable(true)]
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