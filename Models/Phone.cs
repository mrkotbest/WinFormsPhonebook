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
			get => Id;
			set
			{
				Id = value;
				_lastId = Math.Max(_lastId, Id);
			}
		}

		public string Number { get; set; }
		public string Type { get; set; }

        public Phone() { Id = ++_lastId; }

		public override string ToString() => $"{Number} ({Type})";
	}
}