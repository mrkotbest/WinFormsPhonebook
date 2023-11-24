namespace WF_Phonebook.Models
{
	public class Address
	{
		private static int _nextId = 1;
		public int Id { get; set; }
		public string Street { get; set; }
		public int HouseNo { get; set; }
		public int ApartmentNo { get; set; }

        public Address() { }
        public Address(string street, int houseNo, int apartmentNo)
		{
			Id = _nextId++;
			Street = street;
			HouseNo = houseNo;
			ApartmentNo = apartmentNo;
		}

		public override string ToString() => $"{Street} {HouseNo}/{ApartmentNo}";
	}
}