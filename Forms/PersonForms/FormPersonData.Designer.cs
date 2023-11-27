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
			this.formPersonDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbGender = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
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
			lblBirthDate.Location = new System.Drawing.Point(32, 118);
			lblBirthDate.Name = "lblBirthDate";
			lblBirthDate.Size = new System.Drawing.Size(57, 13);
			lblBirthDate.TabIndex = 8;
			lblBirthDate.Text = "Birth Date:";
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Location = new System.Drawing.Point(29, 26);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new System.Drawing.Size(60, 13);
			lblFirstName.TabIndex = 5;
			lblFirstName.Text = "First Name:";
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Location = new System.Drawing.Point(44, 88);
			lblGender.Name = "lblGender";
			lblGender.Size = new System.Drawing.Size(45, 13);
			lblGender.TabIndex = 7;
			lblGender.Text = "Gender:";
			// 
			// lblLastName
			// 
			lblLastName.AutoSize = true;
			lblLastName.Location = new System.Drawing.Point(29, 57);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new System.Drawing.Size(61, 13);
			lblLastName.TabIndex = 6;
			lblLastName.Text = "Last Name:";
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(32, 162);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(275, 32);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dpBirthDate
			// 
			this.dpBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.formPersonDataBindingSource, "Person.BirthDate", true));
			this.dpBirthDate.Location = new System.Drawing.Point(96, 117);
			this.dpBirthDate.Name = "dpBirthDate";
			this.dpBirthDate.Size = new System.Drawing.Size(211, 20);
			this.dpBirthDate.TabIndex = 3;
			// 
			// formPersonDataBindingSource
			// 
			this.formPersonDataBindingSource.DataSource = typeof(WF_Phonebook.Forms.FormPersonData);
			// 
			// tbFirstName
			// 
			this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.FirstName", true));
			this.tbFirstName.Location = new System.Drawing.Point(96, 22);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(211, 20);
			this.tbFirstName.TabIndex = 0;
			// 
			// tbGender
			// 
			this.tbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.Gender", true));
			this.tbGender.Location = new System.Drawing.Point(96, 84);
			this.tbGender.Name = "tbGender";
			this.tbGender.Size = new System.Drawing.Size(211, 20);
			this.tbGender.TabIndex = 2;
			// 
			// tbLastName
			// 
			this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formPersonDataBindingSource, "Person.LastName", true));
			this.tbLastName.Location = new System.Drawing.Point(96, 53);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(211, 20);
			this.tbLastName.TabIndex = 1;
			// 
			// FormPersonData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 221);
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
			this.Text = "Person Data";
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