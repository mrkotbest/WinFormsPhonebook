using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Phone
	{
		[XmlAttribute("Id")]
		public int Id { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }

		public override string ToString()
			=> $"{Number} ({Type})";

		public Phone Clone()
			=> (Phone)MemberwiseClone();

		public void CopyFrom(Phone other)
		{
			Id = other.Id;
			Number = other.Number;
			Type = other.Type;
		}
	}
}