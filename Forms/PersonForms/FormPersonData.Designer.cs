namespace WF_Phonebook.Forms
{
	partial class FormPersonData
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label birthDateLabel;
			System.Windows.Forms.Label firstNameLabel;
			System.Windows.Forms.Label genderLabel;
			System.Windows.Forms.Label lastNameLabel;
			this.btnSave = new System.Windows.Forms.Button();
			this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbGender = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			birthDateLabel = new System.Windows.Forms.Label();
			firstNameLabel = new System.Windows.Forms.Label();
			genderLabel = new System.Windows.Forms.Label();
			lastNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// birthDateLabel
			// 
			birthDateLabel.AutoSize = true;
			birthDateLabel.Location = new System.Drawing.Point(26, 105);
			birthDateLabel.Name = "birthDateLabel";
			birthDateLabel.Size = new System.Drawing.Size(57, 13);
			birthDateLabel.TabIndex = 9;
			birthDateLabel.Text = "Birth Date:";
			// 
			// firstNameLabel
			// 
			firstNameLabel.AutoSize = true;
			firstNameLabel.Location = new System.Drawing.Point(26, 25);
			firstNameLabel.Name = "firstNameLabel";
			firstNameLabel.Size = new System.Drawing.Size(60, 13);
			firstNameLabel.TabIndex = 6;
			firstNameLabel.Text = "First Name:";
			// 
			// genderLabel
			// 
			genderLabel.AutoSize = true;
			genderLabel.Location = new System.Drawing.Point(26, 77);
			genderLabel.Name = "genderLabel";
			genderLabel.Size = new System.Drawing.Size(45, 13);
			genderLabel.TabIndex = 8;
			genderLabel.Text = "Gender:";
			// 
			// lastNameLabel
			// 
			lastNameLabel.AutoSize = true;
			lastNameLabel.Location = new System.Drawing.Point(26, 51);
			lastNameLabel.Name = "lastNameLabel";
			lastNameLabel.Size = new System.Drawing.Size(61, 13);
			lastNameLabel.TabIndex = 7;
			lastNameLabel.Text = "Last Name:";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(29, 142);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(273, 32);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// peopleBindingSource
			// 
			this.peopleBindingSource.DataSource = typeof(WF_Phonebook.Models.Person);
			// 
			// dpBirthDate
			// 
			this.dpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peopleBindingSource, "BirthDate", true));
			this.dpBirthDate.Location = new System.Drawing.Point(87, 101);
			this.dpBirthDate.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
			this.dpBirthDate.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
			this.dpBirthDate.Name = "dpBirthDate";
			this.dpBirthDate.Size = new System.Drawing.Size(215, 20);
			this.dpBirthDate.TabIndex = 4;
			// 
			// tbFirstName
			// 
			this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "FirstName", true));
			this.tbFirstName.Location = new System.Drawing.Point(87, 22);
			this.tbFirstName.MaxLength = 20;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(215, 20);
			this.tbFirstName.TabIndex = 1;
			this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
			// 
			// tbGender
			// 
			this.tbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Gender", true));
			this.tbGender.Location = new System.Drawing.Point(87, 74);
			this.tbGender.MaxLength = 6;
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(215, 20);
			this.tbGender.TabIndex = 3;
			this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGender_KeyPress);
			// 
			// tbLastName
			// 
			this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "LastName", true));
			this.tbLastName.Location = new System.Drawing.Point(87, 48);
			this.tbLastName.MaxLength = 25;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(215, 20);
			this.tbLastName.TabIndex = 2;
			this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
			// 
			// FormPersonData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 191);
			this.Controls.Add(birthDateLabel);
			this.Controls.Add(this.dpBirthDate);
			this.Controls.Add(firstNameLabel);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(genderLabel);
			this.Controls.Add(this.tbGender);
			this.Controls.Add(lastNameLabel);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPersonData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Person Data";
			((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.BindingSource peopleBindingSource;
		private System.Windows.Forms.DateTimePicker dpBirthDate;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.TextBox tbGender;
		private System.Windows.Forms.TextBox tbLastName;
	}
}