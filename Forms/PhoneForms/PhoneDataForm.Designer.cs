namespace WF_Phonebook.Forms.PhoneForms
{
	partial class PhoneDataForm
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
			System.Windows.Forms.Label lblNumber;
			System.Windows.Forms.Label lblType;
			this.btnSave = new System.Windows.Forms.Button();
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbType = new System.Windows.Forms.TextBox();
			lblNumber = new System.Windows.Forms.Label();
			lblType = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNumber
			// 
			lblNumber.AutoSize = true;
			lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblNumber.Location = new System.Drawing.Point(26, 28);
			lblNumber.Name = "lblNumber";
			lblNumber.Size = new System.Drawing.Size(55, 15);
			lblNumber.TabIndex = 3;
			lblNumber.Text = "Number:";
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblType.Location = new System.Drawing.Point(45, 57);
			lblType.Name = "lblType";
			lblType.Size = new System.Drawing.Size(36, 15);
			lblType.TabIndex = 4;
			lblType.Text = "Type:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Honeydew;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(29, 96);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(253, 35);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tbNumber
			// 
			this.tbNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Number", true));
			this.tbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNumber.Location = new System.Drawing.Point(83, 25);
			this.tbNumber.MaxLength = 13;
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(199, 22);
			this.tbNumber.TabIndex = 0;
			this.tbNumber.Leave += new System.EventHandler(this.tbNumber_Leave);
			// 
			// phoneListBindingSource
			// 
			this.phoneListBindingSource.DataSource = typeof(WF_Phonebook.Models.Phone);
			// 
			// tbType
			// 
			this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Type", true));
			this.tbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbType.Location = new System.Drawing.Point(83, 54);
			this.tbType.MaxLength = 9;
			this.tbType.Name = "tbType";
			this.tbType.Size = new System.Drawing.Size(199, 22);
			this.tbType.TabIndex = 1;
			this.tbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbType_KeyPress);
			// 
			// PhoneDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(314, 161);
			this.Controls.Add(lblNumber);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(lblType);
			this.Controls.Add(this.tbType);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "PhoneDataForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Phone Input";
			this.Load += new System.EventHandler(this.FormPhoneData_Load);
			((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource phoneListBindingSource;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.TextBox tbType;
	}
}