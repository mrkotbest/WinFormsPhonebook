using System;
using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Person
	{
		[XmlAttribute("Id")]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Gender { get; set; }
		public DateTime BirthDate { get; set; } = DateTime.Today;

		public override string ToString()
			=> $"{FirstName} {LastName} [{Gender}] {BirthDate.Date.ToShortDateString()}";
	}
}