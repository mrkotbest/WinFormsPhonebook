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
			System.Windows.Forms.Label numberLabel;
			System.Windows.Forms.Label typeLabel;
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tbType = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			numberLabel = new System.Windows.Forms.Label();
			typeLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// numberLabel
			// 
			numberLabel.AutoSize = true;
			numberLabel.Location = new System.Drawing.Point(38, 34);
			numberLabel.Name = "numberLabel";
			numberLabel.Size = new System.Drawing.Size(47, 13);
			numberLabel.TabIndex = 4;
			numberLabel.Text = "Number:";
			// 
			// typeLabel
			// 
			typeLabel.AutoSize = true;
			typeLabel.Location = new System.Drawing.Point(38, 60);
			typeLabel.Name = "typeLabel";
			typeLabel.Size = new System.Drawing.Size(34, 13);
			typeLabel.TabIndex = 5;
			typeLabel.Text = "Type:";
			// 
			// tbNumber
			// 
			this.tbNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Number", true));
			this.tbNumber.Location = new System.Drawing.Point(91, 31);
			this.tbNumber.MaxLength = 13;
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(196, 20);
			this.tbNumber.TabIndex = 1;
			this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
			this.tbNumber.Validated += new System.EventHandler(this.tbNumber_Validated);
			// 
			// phoneListBindingSource
			// 
			this.phoneListBindingSource.DataSource = typeof(WF_Phonebook.Models.Phone);
			// 
			// tbType
			// 
			this.tbType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneListBindingSource, "Type", true));
			this.tbType.Location = new System.Drawing.Point(91, 57);
			this.tbType.MaxLength = 6;
			this.tbType.Name = "tbType";
			this.tbType.Size = new System.Drawing.Size(196, 20);
			this.tbType.TabIndex = 2;
			this.tbType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbType_KeyPress);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(41, 97);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(246, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormPhoneData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 161);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(numberLabel);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(typeLabel);
			this.Controls.Add(this.tbType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormPhoneData";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Phone Data";
			((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource phoneListBindingSource;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.TextBox tbType;
		private System.Windows.Forms.Button btnSave;
	}
}