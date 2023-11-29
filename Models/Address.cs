using System;
using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Address
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

		public int HouseNo { get; set; }
		public int ApartmentNo { get; set; }
		public string Street { get; set; }

        public Address() { Id = ++_lastId; }

		public override string ToString() => $"{Street} {HouseNo}/{ApartmentNo}";
	}
}