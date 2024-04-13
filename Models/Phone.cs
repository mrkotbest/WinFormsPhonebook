using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Phone
	{
		[XmlAttribute("Id")]
		public int Id { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }

		public override string ToString() => $"{Number} ({Type})";
	}
}