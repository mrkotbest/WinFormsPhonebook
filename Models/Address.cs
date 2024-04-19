using System.Xml.Serialization;

namespace WF_Phonebook.Models
{
	public class Address
	{
		[XmlAttribute("Id")]
		public int Id { get; set; }
		public int HouseNo { get; set; }
		public int ApartmentNo { get; set; }
		public string Street { get; set; }

		public override string ToString()
			=> $"{Street} {HouseNo}/{ApartmentNo}";

		public Address Clone()
			=> (Address)MemberwiseClone();

		public void CopyFrom(Address other)
		{
			Id = other.Id;
			HouseNo = other.HouseNo;
			ApartmentNo = other.ApartmentNo;
			Street = other.Street;
		}
	}
}