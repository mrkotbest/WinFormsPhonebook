using System;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormAddressData : Form
	{
		public Mode CurrentMode { get; }
		public Address Address { get; set; }

		public FormAddressData(Mode mode, Address address = null)
		{
			InitializeComponent();
			CurrentMode = mode;
			Address = address;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbStreet.Text) || string.IsNullOrEmpty(tbHouse.Text) || string.IsNullOrEmpty(tbApartment.Text))
			{
				MessageBox.Show("You need to fill in all the fields!", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				Address = new Address(Convert.ToInt32(tbHouse.Text), Convert.ToInt32(tbApartment.Text), tbStreet.Text);
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void FormAddressData_Load(object sender, EventArgs e)
		{
			if (CurrentMode == Mode.Edit && Address != null)
			{
				formAddressDataBindingSource.DataSource = Address;
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
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}