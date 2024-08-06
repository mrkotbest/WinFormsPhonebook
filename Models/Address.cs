namespace WF_Phonebook.Models
{
	public sealed class Address
	{
		public int Id { get; set; }
		public int HouseNo { get; set; } = 1;
		public int ApartmentNo { get; set; } = 1;
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