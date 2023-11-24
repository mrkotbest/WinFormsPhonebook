using System.ComponentModel;

namespace WF_Phonebook.Models
{
	public class Phone
	{
		[Browsable(true)]
		public string Number { get; set; }
		[Browsable(true)]
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