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
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPerson
			// 
			this.lblPerson.AutoSize = true;
			this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPerson.Location = new System.Drawing.Point(18, 30);
			this.lblPerson.Name = "lblPerson";
			this.lblPerson.Size = new System.Drawing.Size(49, 15);
			this.lblPerson.TabIndex = 13;
			this.lblPerson.Text = "Person:";
			// 
			// tbPerson
			// 
			this.tbPerson.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPerson.Location = new System.Drawing.Point(73, 28);
			this.tbPerson.Name = "tbPerson";
			this.tbPerson.ReadOnly = true;
			this.tbPerson.Size = new System.Drawing.Size(275, 22);
			this.tbPerson.TabIndex = 10;
			this.tbPerson.TabStop = false;
			// 
			// btnPersonInfo
			// 
			this.btnPersonInfo.BackColor = System.Drawing.Color.Azure;
			this.btnPersonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPersonInfo.Location = new System.Drawing.Point(365, 28);
			this.btnPersonInfo.Name = "btnPersonInfo";
			this.btnPersonInfo.Size = new System.Drawing.Size(35, 22);
			this.btnPersonInfo.TabIndex = 1;
			this.btnPersonInfo.Text = "...";
			this.btnPersonInfo.UseVisualStyleBackColor = false;
			this.btnPersonInfo.Click += new System.EventHandler(this.btnPersonInfo_Click);
			// 
			// btnPersonRemove
			// 
			this.btnPersonRemove.BackColor = System.Drawing.Color.GhostWhite;
			this.btnPersonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPersonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPersonRemove.Location = new System.Drawing.Point(406, 28);
			this.btnPersonRemove.Name = "btnPersonRemove";
			this.btnPersonRemove.Size = new System.Drawing.Size(35, 22);
			this.btnPersonRemove.TabIndex = 2;
			this.btnPersonRemove.Text = "X";
			this.btnPersonRemove.UseVisualStyleBackColor = false;
			this.btnPersonRemove.Click += new System.EventHandler(this.btnPersonRemove_Click);
			// 
			// btnAddressRemove
			// 
			this.btnAddressRemove.BackColor = System.Drawing.Color.GhostWhite;
			this.btnAddressRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddressRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddressRemove.Location = new System.Drawing.Point(406, 56);
			this.btnAddressRemove.Name = "btnAddressRemove";
			this.btnAddressRemove.Size = new System.Drawing.Size(35, 22);
			this.btnAddressRemove.TabIndex = 4;
			this.btnAddressRemove.Text = "X";
			this.btnAddressRemove.UseVisualStyleBackColor = false;
			this.btnAddressRemove.Click += new System.EventHandler(this.btnAddressRemove_Click);
			// 
			// btnAddressInfo
			// 
			this.btnAddressInfo.BackColor = System.Drawing.Color.Azure;
			this.btnAddressInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddressInfo.Location = new System.Drawing.Point(365, 56);
			this.btnAddressInfo.Name = "btnAddressInfo";
			this.btnAddressInfo.Size = new System.Drawing.Size(35, 22);
			this.btnAddressInfo.TabIndex = 3;
			this.btnAddressInfo.Text = "...";
			this.btnAddressInfo.UseVisualStyleBackColor = false;
			this.btnAddressInfo.Click += new System.EventHandler(this.btnAddressInfo_Click);
			// 
			// tbAddress
			// 
			this.tbAddress.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAddress.Location = new System.Drawing.Point(73, 56);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.ReadOnly = true;
			this.tbAddress.Size = new System.Drawing.Size(275, 22);
			this.tbAddress.TabIndex = 11;
			this.tbAddress.TabStop = false;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAddress.Location = new System.Drawing.Point(13, 58);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(54, 15);
			this.lblAddress.TabIndex = 14;
			this.lblAddress.Text = "Address:";
			// 
			// btnPhoneRemove
			// 
			this.btnPhoneRemove.BackColor = System.Drawing.Color.GhostWhite;
			this.btnPhoneRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPhoneRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPhoneRemove.Location = new System.Drawing.Point(406, 84);
			this.btnPhoneRemove.Name = "btnPhoneRemove";
			this.btnPhoneRemove.Size = new System.Drawing.Size(35, 22);
			this.btnPhoneRemove.TabIndex = 6;
			this.btnPhoneRemove.Text = "X";
			this.btnPhoneRemove.UseVisualStyleBackColor = false;
			this.btnPhoneRemove.Click += new System.EventHandler(this.btnPhoneRemove_Click);
			// 
			// btnPhoneInfo
			// 
			this.btnPhoneInfo.BackColor = System.Drawing.Color.Azure;
			this.btnPhoneInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPhoneInfo.Location = new System.Drawing.Point(365, 84);
			this.btnPhoneInfo.Name = "btnPhoneInfo";
			this.btnPhoneInfo.Size = new System.Drawing.Size(35, 22);
			this.btnPhoneInfo.TabIndex = 5;
			this.btnPhoneInfo.Text = "...";
			this.btnPhoneInfo.UseVisualStyleBackColor = false;
			this.btnPhoneInfo.Click += new System.EventHandler(this.btnPhoneInfo_Click);
			// 
			// tbPhone
			// 
			this.tbPhone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPhone.Location = new System.Drawing.Point(73, 84);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.ReadOnly = true;
			this.tbPhone.Size = new System.Drawing.Size(275, 22);
			this.tbPhone.TabIndex = 12;
			this.tbPhone.TabStop = false;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPhone.Location = new System.Drawing.Point(21, 86);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(46, 15);
			this.lblPhone.TabIndex = 15;
			this.lblPhone.Text = "Phone:";
			// 
			// tbEmail
			// 
			this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbEmail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbEmail.Location = new System.Drawing.Point(73, 112);
			this.tbEmail.MaxLength = 35;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(275, 22);
			this.tbEmail.TabIndex = 7;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblEmail.Location = new System.Drawing.Point(25, 114);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(42, 15);
			this.lblEmail.TabIndex = 16;
			this.lblEmail.Text = "Email:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Ivory;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Desktop;
			this.btnAdd.Location = new System.Drawing.Point(20, 153);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(105, 35);
			this.btnAdd.TabIndex = 9;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Desktop;
			this.btnCancel.Location = new System.Drawing.Point(136, 153);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(105, 35);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(464, 211);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
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
			this.Text = "New Contact";
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
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
	}
}