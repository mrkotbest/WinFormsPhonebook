namespace WF_Phonebook.Forms
{
	partial class FormPhoneData
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
			this.tbType = new System.Windows.Forms.TextBox();
			this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			lblNumber = new System.Windows.Forms.Label();
			lblType = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(32, 98);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(249, 35);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblNumber
			// 
			lblNumber.AutoSize = true;
			lblNumber.Location = new System.Drawing.Point(29, 30);
			lblNumber.Name = "lblNumber";
			lblNumber.Size = new System.Drawing.Size(47, 13);
			lblNumber.TabIndex = 3;
			lblNumber.Text = "Number:";
			// 
			// tbNumber
			// 
			this.tbNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Number", true));
			this.tbNumber.Location = new System.Drawing.Point(82, 27);
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(199, 20);
			this.tbNumber.TabIndex = 0;
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.Location = new System.Drawing.Point(42, 59);
			lblType.Name = "lblType";
			lblType.Size = new System.Drawing.Size(34, 13);
			lblType.TabIndex = 4;
			lblType.Text = "Type:";
			// 
			// tbType
			// 
			this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Type", true));
			this.tbType.Location = new System.Drawing.Point(82, 56);
			this.tbType.Name = "tbType";
			this.tbType.Size = new System.Drawing.Size(199, 20);
			this.tbType.TabIndex = 1;
			// 
			// phoneListBindingSource
			// 
			this.phoneListBindingSource.DataSource = typeof(WF_Phonebook.Models.Phone);
			// 
			// FormPhoneData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 161);
			this.Controls.Add(lblNumber);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(lblType);
			this.Controls.Add(this.tbType);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPhoneData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Phone Data";
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