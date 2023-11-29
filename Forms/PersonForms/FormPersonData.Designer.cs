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
			System.Windows.Forms.Label lblBirthDate;
			System.Windows.Forms.Label lblFirstName;
			System.Windows.Forms.Label lblGender;
			System.Windows.Forms.Label lblLastName;
			this.btnSave = new System.Windows.Forms.Button();
			this.dpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbGender = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.formPersonDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			lblBirthDate = new System.Windows.Forms.Label();
			lblFirstName = new System.Windows.Forms.Label();
			lblGender = new System.Windows.Forms.Label();
			lblLastName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.formPersonDataBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBirthDate
			// 
			lblBirthDate.AutoSize = true;
			lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblBirthDate.Location = new System.Drawing.Point(27, 119);
			lblBirthDate.Name = "lblBirthDate";
			lblBirthDate.Size = new System.Drawing.Size(64, 15);
			lblBirthDate.TabIndex = 8;
			lblBirthDate.Text = "Birth Date:";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblFirstName.Location = new System.Drawing.Point(24, 26);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new System.Drawing.Size(70, 15);
			lblFirstName.TabIndex = 5;
			lblFirstName.Text = "First Name:";
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblGender.Location = new System.Drawing.Point(39, 88);
			lblGender.Name = "lblGender";
			lblGender.Size = new System.Drawing.Size(51, 15);
			lblGender.TabIndex = 7;
			lblGender.Text = "Gender:";
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblLastName.Location = new System.Drawing.Point(24, 57);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new System.Drawing.Size(70, 15);
			lblLastName.TabIndex = 6;
			lblLastName.Text = "Last Name:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Honeydew;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(32, 162);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(289, 32);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dpBirthDate
			// 
			this.dpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formPersonDataBindingSource, "Person.BirthDate", true));
			this.dpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpBirthDate.Location = new System.Drawing.Point(96, 117);
			this.dpBirthDate.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
			this.dpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dpBirthDate.Name = "dpBirthDate";
			this.dpBirthDate.Size = new System.Drawing.Size(225, 22);
			this.dpBirthDate.TabIndex = 3;
			this.dpBirthDate.Value = new System.DateTime(2023, 11, 29, 0, 0, 0, 0);
			// 
			// tbFirstName
			// 
			this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.FirstName", true));
			this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFirstName.Location = new System.Drawing.Point(96, 22);
			this.tbFirstName.MaxLength = 25;
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(225, 22);
			this.tbFirstName.TabIndex = 0;
			this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFirstName_KeyPress);
			// 
			// tbGender
			// 
			this.tbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.Gender", true));
			this.tbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbGender.Location = new System.Drawing.Point(96, 84);
			this.tbGender.MaxLength = 6;
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(225, 22);
			this.tbGender.TabIndex = 2;
			this.tbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGender_KeyPress);
			// 
			// tbLastName
			// 
			this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.LastName", true));
			this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastName.Location = new System.Drawing.Point(96, 53);
			this.tbLastName.MaxLength = 30;
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(225, 22);
			this.tbLastName.TabIndex = 1;
			this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLastName_KeyPress);
			// 
			// formPersonDataBindingSource
			// 
			this.formPersonDataBindingSource.DataSource = typeof(WF_Phonebook.Forms.FormPersonData);
			// 
			// FormPersonData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(354, 221);
			this.Controls.Add(lblBirthDate);
			this.Controls.Add(this.dpBirthDate);
			this.Controls.Add(lblFirstName);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(lblGender);
			this.Controls.Add(this.tbGender);
			this.Controls.Add(lblLastName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPersonData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Person Input";
			this.Load += new System.EventHandler(this.FormPersonData_Load);
			((System.ComponentModel.ISupportInitialize)(this.formPersonDataBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.BindingSource formPersonDataBindingSource;
		private System.Windows.Forms.DateTimePicker dpBirthDate;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.TextBox tbGender;
		private System.Windows.Forms.TextBox tbLastName;
	}
}