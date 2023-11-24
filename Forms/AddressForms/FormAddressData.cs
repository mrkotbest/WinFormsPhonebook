using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressData : Form
	{
		public BindingList<Address> AddressList { get; set; }
		public Address CurrentAddress { get; set; }
		public Mode CurrentMode { get; set; }

		public FormAddressData(BindingList<Address> addressList, Mode mode, Address address = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			CurrentAddress = address;
			AddressList = addressList;

			if (CurrentMode == Mode.Edit)
			{
				tbStreet.Text = CurrentAddress.Street;
				tbHouse.Text = CurrentAddress.HouseNo.ToString();
				tbApartment.Text = CurrentAddress.ApartmentNo.ToString();
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbStreet.Text == string.Empty | tbHouse.Text == string.Empty | tbApartment.Text == string.Empty)
			{
				MessageBox.Show("You need to fill in all the fields!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				if (CurrentMode == Mode.Add)
				{
					AddressList.Add(new Address(tbStreet.Text, Convert.ToInt32(tbHouse.Text), Convert.ToInt32(tbApartment.Text)));
				}
				else if (CurrentMode == Mode.Edit)
				{
					CurrentAddress.Street = tbStreet.Text;
					CurrentAddress.HouseNo = Convert.ToInt32(tbHouse.Text);
					CurrentAddress.ApartmentNo = Convert.ToInt32(tbApartment.Text);
				}
				Close();
			}
		}

		private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbHouse_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a number
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbApartment_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a number
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}