using System;
using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Phone
	{
		private static int _lastId = 0;
		[XmlIgnore]
		public int Id { get; set; }
		[XmlAttribute("Id")]
		public int SerializableId
		{
			get { return Id; }
			set
			{
				Id = value;
				_lastId = Math.Max(_lastId, Id);
			}
		}
		public string Number { get; set; }
		public string Type { get; set; }        // Type of the Phone

        public Phone() { }
        public Phone(string number, string type)
		{
			Id = ++_lastId;
			Number = number;
			Type = type;
		}

		public override string ToString() => $"{Number} ({Type})";
	}
}