using System;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressData : Form
	{
		private readonly Address _tempAddress;
		public Address Address { get; }

		public FormAddressData(Address address)
		{
			InitializeComponent();
			Address = address;
			_tempAddress = address.Clone();
		}

		private void FormAddressData_Load(object sender, EventArgs e)
			=> formAddressDataBindingSource.DataSource = _tempAddress ?? formAddressDataBindingSource.DataSource;

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbStreet.Text) || string.IsNullOrEmpty(tbHouse.Text) || string.IsNullOrEmpty(tbApartment.Text))
			{
				MessageBox.Show("All fields must be filled in!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Address.CopyFrom(_tempAddress);

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		// Checking if a symbol is a letter or a control symbol (eg "Backspace").
		private void tbStreet_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbHouse_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbApartment_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}