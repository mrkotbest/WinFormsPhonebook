using System.ComponentModel;
using System.Runtime.Serialization;

namespace WF_Phonebook.Models
{
	public class Address
	{
		[Browsable(true)]
		public string Street { get; set; }
		[Browsable(true)]
		public int HouseNo { get; set; }
		[Browsable(true)]
		public int ApartmentNo { get; set; }

        public Address() { }
        public Address(string street, int houseNo, int apartmentNo)
		{
			Street = street;
			HouseNo = houseNo;
			ApartmentNo = apartmentNo;
		}

		public override string ToString() => $"{Street} {HouseNo}/{ApartmentNo}";
	}
}