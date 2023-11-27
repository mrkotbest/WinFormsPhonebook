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
			System.Windows.Forms.Label lblApartment;
			System.Windows.Forms.Label lblHouse;
			System.Windows.Forms.Label lblStreet;
			this.btnSave = new System.Windows.Forms.Button();
			this.formAddressDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbApartment = new System.Windows.Forms.TextBox();
			this.tbHouse = new System.Windows.Forms.TextBox();
			this.tbStreet = new System.Windows.Forms.TextBox();
			lblApartment = new System.Windows.Forms.Label();
			lblHouse = new System.Windows.Forms.Label();
			lblStreet = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.formAddressDataBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(27, 123);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(272, 34);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// formAddressDataBindingSource
			// 
			this.formAddressDataBindingSource.DataSource = typeof(WF_Phonebook.Forms.FormAddressData);
			// 
			// lblApartment
			// 
			lblApartment.AutoSize = true;
			lblApartment.Location = new System.Drawing.Point(24, 87);
			lblApartment.Name = "lblApartment";
			lblApartment.Size = new System.Drawing.Size(75, 13);
			lblApartment.TabIndex = 6;
			lblApartment.Text = "Apartment No:";
			// 
			// tbApartment
			// 
			this.tbApartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.ApartmentNo", true));
			this.tbApartment.Location = new System.Drawing.Point(105, 84);
			this.tbApartment.Name = "tbApartment";
			this.tbApartment.Size = new System.Drawing.Size(194, 20);
			this.tbApartment.TabIndex = 2;
			// 
			// lblHouse
			// 
			lblHouse.AutoSize = true;
			lblHouse.Location = new System.Drawing.Point(41, 59);
			lblHouse.Name = "lblHouse";
			lblHouse.Size = new System.Drawing.Size(58, 13);
			lblHouse.TabIndex = 5;
			lblHouse.Text = "House No:";
			// 
			// tbHouse
			// 
			this.tbHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.HouseNo", true));
			this.tbHouse.Location = new System.Drawing.Point(105, 56);
			this.tbHouse.Name = "tbHouse";
			this.tbHouse.Size = new System.Drawing.Size(194, 20);
			this.tbHouse.TabIndex = 1;
			// 
			// lblStreet
			// 
			lblStreet.AutoSize = true;
			lblStreet.Location = new System.Drawing.Point(61, 30);
			lblStreet.Name = "lblStreet";
			lblStreet.Size = new System.Drawing.Size(38, 13);
			lblStreet.TabIndex = 4;
			lblStreet.Text = "Street:";
			// 
			// tbStreet
			// 
			this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.Street", true));
			this.tbStreet.Location = new System.Drawing.Point(105, 27);
			this.tbStreet.Name = "tbStreet";
			this.tbStreet.Size = new System.Drawing.Size(194, 20);
			this.tbStreet.TabIndex = 0;
			// 
			// FormAddressData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 181);
			this.Controls.Add(lblApartment);
			this.Controls.Add(this.tbApartment);
			this.Controls.Add(lblHouse);
			this.Controls.Add(this.tbHouse);
			this.Controls.Add(lblStreet);
			this.Controls.Add(this.tbStreet);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormAddressData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Address Data";
			this.Load += new System.EventHandler(this.FormAddressData_Load);
			((System.ComponentModel.ISupportInitialize)(this.formAddressDataBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.BindingSource formAddressDataBindingSource;
		private System.Windows.Forms.TextBox tbApartment;
		private System.Windows.Forms.TextBox tbHouse;
		private System.Windows.Forms.TextBox tbStreet;
	}
}