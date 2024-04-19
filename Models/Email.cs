namespace WF_Phonebook.Models
{
	public class Email
	{
		public string EmailStr { get; set; }

		public Email Clone()
			=> (Email)MemberwiseClone();

		public void CopyFrom(Email email)
		{
			EmailStr = email.EmailStr;
		}
	}
}