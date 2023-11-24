namespace WF_Phonebook.Models
{
	public class Phone
	{
		public int Id { get; set; }
		public string Number { get; set; }
		public string Type { get; set; }        // Type of the Phone

        public Phone() { }
        public Phone(string number, string type)
		{
			Number = number;
			Type = type;
		}

		public override string ToString() => $"{Number} ({Type})";
	}
}