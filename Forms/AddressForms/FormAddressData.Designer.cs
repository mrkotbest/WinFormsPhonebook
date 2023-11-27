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
			this.tbApartment = new System.Windows.Forms.TextBox();
			this.tbHouse = new System.Windows.Forms.TextBox();
			this.tbStreet = new System.Windows.Forms.TextBox();
			this.formAddressDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
			lblApartment = new System.Windows.Forms.Label();
			lblHouse = new System.Windows.Forms.Label();
			lblStreet = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.formAddressDataBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblApartment
			// 
			lblApartment.AutoSize = true;
			lblApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblApartment.Location = new System.Drawing.Point(30, 86);
			lblApartment.Name = "lblApartment";
			lblApartment.Size = new System.Drawing.Size(85, 15);
			lblApartment.TabIndex = 6;
			lblApartment.Text = "Apartment No:";
			// 
			// lblHouse
			// 
			lblHouse.AutoSize = true;
			lblHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblHouse.Location = new System.Drawing.Point(50, 57);
			lblHouse.Name = "lblHouse";
			lblHouse.Size = new System.Drawing.Size(65, 15);
			lblHouse.TabIndex = 5;
			lblHouse.Text = "House No:";
			// 
			// lblStreet
			// 
			lblStreet.AutoSize = true;
			lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblStreet.Location = new System.Drawing.Point(74, 28);
			lblStreet.Name = "lblStreet";
			lblStreet.Size = new System.Drawing.Size(42, 15);
			lblStreet.TabIndex = 4;
			lblStreet.Text = "Street:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Honeydew;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(27, 122);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(289, 34);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbApartment
			// 
			this.tbApartment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.ApartmentNo", true));
			this.tbApartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbApartment.Location = new System.Drawing.Point(115, 83);
			this.tbApartment.MaxLength = 5;
			this.tbApartment.Name = "tbApartment";
			this.tbApartment.Size = new System.Drawing.Size(201, 22);
			this.tbApartment.TabIndex = 2;
			this.tbApartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApartment_KeyPress);
			// 
			// tbHouse
			// 
			this.tbHouse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.HouseNo", true));
			this.tbHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbHouse.Location = new System.Drawing.Point(115, 55);
			this.tbHouse.MaxLength = 3;
			this.tbHouse.Name = "tbHouse";
			this.tbHouse.Size = new System.Drawing.Size(201, 22);
			this.tbHouse.TabIndex = 1;
			this.tbHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHouse_KeyPress);
			// 
			// tbStreet
			// 
			this.tbStreet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.formAddressDataBindingSource, "Address.Street", true));
			this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbStreet.Location = new System.Drawing.Point(115, 26);
			this.tbStreet.MaxLength = 50;
			this.tbStreet.Name = "tbStreet";
			this.tbStreet.Size = new System.Drawing.Size(201, 22);
			this.tbStreet.TabIndex = 0;
			this.tbStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStreet_KeyPress);
			// 
			// formAddressDataBindingSource
			// 
			this.formAddressDataBindingSource.DataSource = typeof(WF_Phonebook.Forms.FormAddressData);
			// 
			// FormAddressData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(344, 181);
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
			this.Text = "Address Input";
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