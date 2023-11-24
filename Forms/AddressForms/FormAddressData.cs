using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressData : Form
	{
		public Address Address { get; set; }
		public Mode CurrentMode { get; set; }

		public FormAddressData(Mode mode, Address address = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			Address = address;

			if (CurrentMode == Mode.Edit && Address != null)
			{
				tbStreet.Text = Address.Street;
				tbHouse.Text = Address.HouseNo.ToString();
				tbApartment.Text = Address.ApartmentNo.ToString();
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
					Address = new Address(tbStreet.Text, Convert.ToInt32(tbHouse.Text), Convert.ToInt32(tbApartment.Text));
				}
				else if (CurrentMode == Mode.Edit)
				{
					Address = new Address(tbStreet.Text, Convert.ToInt32(tbHouse.Text), Convert.ToInt32(tbApartment.Text));
				}

				DialogResult = DialogResult.OK;
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