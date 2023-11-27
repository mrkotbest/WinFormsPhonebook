using System;
using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Person
	{
		private static int _lastId = 0;

		[XmlIgnore]
		public int Id { get; set; }
		[XmlAttribute("Id")]
		public int SerializableId
		{
			get => Id;
			set
			{
				Id = value;
				_lastId = Math.Max(_lastId, Id);
			}
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public DateTime BirthDate { get; set; }

		public Person() { }
		public Person(string firstName, string lastName, string gender, DateTime birthDate)
		{
			Id = ++_lastId;
			FirstName = firstName;
			LastName = lastName;
			Gender = gender;
			BirthDate = birthDate;
		}

		public override string ToString() => $"{FirstName} {LastName} [{Gender}] {BirthDate.Date.ToShortDateString()}";
	}
}