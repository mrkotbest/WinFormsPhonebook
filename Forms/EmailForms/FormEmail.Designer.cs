namespace WF_Phonebook.Forms.EmailForms
{
	partial class EmailForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label lblEmail;
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			lblEmail = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			lblEmail.Location = new System.Drawing.Point(26, 40);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new System.Drawing.Size(42, 15);
			lblEmail.TabIndex = 1;
			lblEmail.Text = "Email:";
			// 
			// tbEmail
			// 
			this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbEmail.Location = new System.Drawing.Point(74, 39);
			this.tbEmail.MaxLength = 50;
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(211, 21);
			this.tbEmail.TabIndex = 2;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.Honeydew;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSave.Location = new System.Drawing.Point(29, 90);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(256, 35);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// FormEmail
			// 
			this.ClientSize = new System.Drawing.Size(314, 161);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(lblEmail);
			this.Controls.Add(this.tbEmail);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormEmail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Email Input";
			this.Load += new System.EventHandler(this.FormEmail_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.Button btnSave;
	}
}
