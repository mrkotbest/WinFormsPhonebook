namespace WF_Phonebook.Forms
{
	partial class FormContact
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
			this.lblPerson = new System.Windows.Forms.Label();
			this.tbPerson = new System.Windows.Forms.TextBox();
			this.btnPersonInfo = new System.Windows.Forms.Button();
			this.btnPersonRemove = new System.Windows.Forms.Button();
			this.btnAddressRemove = new System.Windows.Forms.Button();
			this.btnAddressInfo = new System.Windows.Forms.Button();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.btnPhoneRemove = new System.Windows.Forms.Button();
			this.btnPhoneInfo = new System.Windows.Forms.Button();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.lblPhone = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.formContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.formContactBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPerson
			// 
			this.lblPerson.AutoSize = true;
			this.lblPerson.Location = new System.Drawing.Point(24, 31);
			this.lblPerson.Name = "lblPerson";
			this.lblPerson.Size = new System.Drawing.Size(43, 13);
			this.lblPerson.TabIndex = 13;
			this.lblPerson.Text = "Person:";
			// 
			// tbPerson
			// 
			this.tbPerson.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPerson.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formContactBindingSource, "Person", true));
			this.tbPerson.Location = new System.Drawing.Point(73, 28);
			this.tbPerson.Name = "tbPerson";
			this.tbPerson.ReadOnly = true;
			this.tbPerson.Size = new System.Drawing.Size(275, 20);
			this.tbPerson.TabIndex = 10;
			this.tbPerson.TabStop = false;
			// 
			// btnPersonInfo
			// 
			this.btnPersonInfo.Location = new System.Drawing.Point(365, 28);
			this.btnPersonInfo.Name = "btnPersonInfo";
			this.btnPersonInfo.Size = new System.Drawing.Size(35, 22);
			this.btnPersonInfo.TabIndex = 1;
			this.btnPersonInfo.Text = "...";
			this.btnPersonInfo.UseVisualStyleBackColor = true;
			this.btnPersonInfo.Click += new System.EventHandler(this.btnPersonInfo_Click);
			// 
			// btnPersonRemove
			// 
			this.btnPersonRemove.Location = new System.Drawing.Point(406, 28);
			this.btnPersonRemove.Name = "btnPersonRemove";
			this.btnPersonRemove.Size = new System.Drawing.Size(35, 22);
			this.btnPersonRemove.TabIndex = 2;
			this.btnPersonRemove.Text = "X";
			this.btnPersonRemove.UseVisualStyleBackColor = true;
			this.btnPersonRemove.Click += new System.EventHandler(this.btnPersonRemove_Click);
			// 
			// btnAddressRemove
			// 
			this.btnAddressRemove.Location = new System.Drawing.Point(406, 54);
			this.btnAddressRemove.Name = "btnAddressRemove";
			this.btnAddressRemove.Size = new System.Drawing.Size(35, 22);
			this.btnAddressRemove.TabIndex = 4;
			this.btnAddressRemove.Text = "X";
			this.btnAddressRemove.UseVisualStyleBackColor = true;
			this.btnAddressRemove.Click += new System.EventHandler(this.btnAddressRemove_Click);
			// 
			// btnAddressInfo
			// 
			this.btnAddressInfo.Location = new System.Drawing.Point(365, 54);
			this.btnAddressInfo.Name = "btnAddressInfo";
			this.btnAddressInfo.Size = new System.Drawing.Size(35, 22);
			this.btnAddressInfo.TabIndex = 3;
			this.btnAddressInfo.Text = "...";
			this.btnAddressInfo.UseVisualStyleBackColor = true;
			this.btnAddressInfo.Click += new System.EventHandler(this.btnAddressInfo_Click);
			// 
			// tbAddress
			// 
			this.tbAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formContactBindingSource, "Address", true));
			this.tbAddress.Location = new System.Drawing.Point(73, 54);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.ReadOnly = true;
			this.tbAddress.Size = new System.Drawing.Size(275, 20);
			this.tbAddress.TabIndex = 11;
			this.tbAddress.TabStop = false;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(24, 57);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(48, 13);
			this.lblAddress.TabIndex = 14;
			this.lblAddress.Text = "Address:";
			// 
			// btnPhoneRemove
			// 
			this.btnPhoneRemove.Location = new System.Drawing.Point(406, 80);
			this.btnPhoneRemove.Name = "btnPhoneRemove";
			this.btnPhoneRemove.Size = new System.Drawing.Size(35, 22);
			this.btnPhoneRemove.TabIndex = 6;
			this.btnPhoneRemove.Text = "X";
			this.btnPhoneRemove.UseVisualStyleBackColor = true;
			this.btnPhoneRemove.Click += new System.EventHandler(this.btnPhoneRemove_Click);
			// 
			// btnPhoneInfo
			// 
			this.btnPhoneInfo.Location = new System.Drawing.Point(365, 80);
			this.btnPhoneInfo.Name = "btnPhoneInfo";
			this.btnPhoneInfo.Size = new System.Drawing.Size(35, 22);
			this.btnPhoneInfo.TabIndex = 5;
			this.btnPhoneInfo.Text = "...";
			this.btnPhoneInfo.UseVisualStyleBackColor = true;
			this.btnPhoneInfo.Click += new System.EventHandler(this.btnPhoneInfo_Click);
			// 
			// tbPhone
			// 
			this.tbPhone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formContactBindingSource, "Phone", true));
			this.tbPhone.Location = new System.Drawing.Point(73, 80);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.ReadOnly = true;
			this.tbPhone.Size = new System.Drawing.Size(275, 20);
			this.tbPhone.TabIndex = 12;
			this.tbPhone.TabStop = false;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(24, 83);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(41, 13);
			this.lblPhone.TabIndex = 15;
			this.lblPhone.Text = "Phone:";
			// 
			// tbEmail
			// 
			this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbEmail.Location = new System.Drawing.Point(73, 108);
			this.tbEmail.MaxLength = 35;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(275, 20);
			this.tbEmail.TabIndex = 7;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Location = new System.Drawing.Point(24, 111);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(35, 13);
			this.lblEmail.TabIndex = 16;
			this.lblEmail.Text = "Email:";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(27, 153);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(105, 35);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(138, 153);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 35);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// formContactBindingSource
			// 
			this.formContactBindingSource.DataSource = typeof(WF_Phonebook.Forms.FormContact);
			// 
			// FormContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 211);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.btnPhoneRemove);
			this.Controls.Add(this.btnPhoneInfo);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.btnAddressRemove);
			this.Controls.Add(this.btnAddressInfo);
			this.Controls.Add(this.tbAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.btnPersonRemove);
			this.Controls.Add(this.btnPersonInfo);
			this.Controls.Add(this.tbPerson);
			this.Controls.Add(this.lblPerson);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormContact";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Contact Data";
			this.Load += new System.EventHandler(this.FormContact_Load);
			((System.ComponentModel.ISupportInitialize)(this.formContactBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPerson;
		private System.Windows.Forms.TextBox tbPerson;
		private System.Windows.Forms.Button btnPersonInfo;
		private System.Windows.Forms.Button btnPersonRemove;
		private System.Windows.Forms.Button btnAddressRemove;
		private System.Windows.Forms.Button btnAddressInfo;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Button btnPhoneRemove;
		private System.Windows.Forms.Button btnPhoneInfo;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label lblPhone;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.BindingSource formContactBindingSource;
	}
}