namespace WF_Phonebook.Forms
{
	partial class FormAddressData
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
			System.Windows.Forms.Label apartmentNoLabel;
			System.Windows.Forms.Label houseNoLabel;
			System.Windows.Forms.Label streetLabel;
			this.addressListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbApartment = new System.Windows.Forms.TextBox();
			this.tbHouse = new System.Windows.Forms.TextBox();
			this.tbStreet = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			apartmentNoLabel = new System.Windows.Forms.Label();
			houseNoLabel = new System.Windows.Forms.Label();
			streetLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// apartmentNoLabel
			// 
			apartmentNoLabel.AutoSize = true;
			apartmentNoLabel.Location = new System.Drawing.Point(31, 86);
			apartmentNoLabel.Name = "apartmentNoLabel";
			apartmentNoLabel.Size = new System.Drawing.Size(75, 13);
			apartmentNoLabel.TabIndex = 7;
			apartmentNoLabel.Text = "Apartment No:";
			// 
			// houseNoLabel
			// 
			houseNoLabel.AutoSize = true;
			houseNoLabel.Location = new System.Drawing.Point(48, 56);
			houseNoLabel.Name = "houseNoLabel";
			houseNoLabel.Size = new System.Drawing.Size(58, 13);
			houseNoLabel.TabIndex = 6;
			houseNoLabel.Text = "House No:";
			// 
			// streetLabel
			// 
			streetLabel.AutoSize = true;
			streetLabel.Location = new System.Drawing.Point(68, 27);
			streetLabel.Name = "streetLabel";
			streetLabel.Size = new System.Drawing.Size(38, 13);
			streetLabel.TabIndex = 5;
			streetLabel.Text = "Street:";
			// 
			// addressListBindingSource
			// 
			this.addressListBindingSource.DataSource = typeof(WF_Phonebook.Models.Address);
			// 
			// tbApartment
			// 
			this.tbApartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressListBindingSource, "ApartmentNo", true));
			this.tbApartment.Location = new System.Drawing.Point(112, 83);
			this.tbApartment.MaxLength = 4;
			this.tbApartment.Name = "tbApartment";
			this.tbApartment.Size = new System.Drawing.Size(180, 20);
			this.tbApartment.TabIndex = 3;
			this.tbApartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApartment_KeyPress);
			// 
			// tbHouse
			// 
			this.tbHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressListBindingSource, "HouseNo", true));
			this.tbHouse.Location = new System.Drawing.Point(112, 53);
			this.tbHouse.MaxLength = 3;
			this.tbHouse.Name = "tbHouse";
			this.tbHouse.Size = new System.Drawing.Size(180, 20);
			this.tbHouse.TabIndex = 2;
			this.tbHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHouse_KeyPress);
			// 
			// tbStreet
			// 
			this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressListBindingSource, "Street", true));
			this.tbStreet.Location = new System.Drawing.Point(112, 24);
			this.tbStreet.MaxLength = 40;
			this.tbStreet.Name = "tbStreet";
			this.tbStreet.Size = new System.Drawing.Size(180, 20);
			this.tbStreet.TabIndex = 1;
			this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreet_KeyPress);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(34, 125);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(258, 34);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormAddressData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 181);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(apartmentNoLabel);
			this.Controls.Add(this.tbApartment);
			this.Controls.Add(houseNoLabel);
			this.Controls.Add(this.tbHouse);
			this.Controls.Add(streetLabel);
			this.Controls.Add(this.tbStreet);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddressData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Address Data";
			((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource addressListBindingSource;
		private System.Windows.Forms.TextBox tbApartment;
		private System.Windows.Forms.TextBox tbHouse;
		private System.Windows.Forms.TextBox tbStreet;
		private System.Windows.Forms.Button btnSave;
	}
}