﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using WF_Phonebook.Models;

namespace WF_Phonebook.Forms
{
	public partial class FormPersonData : Form
	{
		public Person Person { get; set; }
		public Mode CurrentMode { get; set; }

		public FormPersonData(Mode mode, Person person = null)
		{
			InitializeComponent();

			CurrentMode = mode;
			Person = person;

			if (CurrentMode == Mode.Edit && Person != null)
			{
				tbFirstName.Text = Person.FirstName;
				tbLastName.Text = Person.LastName;
				tbGender.Text = Person.Gender;
				dpBirthDate.Value = Person.BirthDate.Date;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (tbFirstName.Text == string.Empty | tbLastName.Text == string.Empty | tbGender.Text == string.Empty)
			{
				MessageBox.Show("All fields must be filled in.", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				if (CurrentMode == Mode.Add)
				{
					Person = new Person(tbFirstName.Text, tbLastName.Text, tbGender.Text, dpBirthDate.Value.Date);
				}
				else if (CurrentMode == Mode.Edit)
				{
					Person = new Person(tbFirstName.Text, tbLastName.Text, tbGender.Text, dpBirthDate.Value.Date);
				}

				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
		private void tbGender_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Checking if a symbol is a letter or a control symbol (eg "Backspace")
			if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
				e.Handled = true;
		}
	}
}