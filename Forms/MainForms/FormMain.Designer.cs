namespace WF_Phonebook.Forms.MainForms
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsPersonItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsAddressItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsPhoneItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsEmailItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemove = new System.Windows.Forms.ToolStripButton();
			this.contactsDataGridView = new System.Windows.Forms.DataGridView();
			this.personDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.Snow;
			this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnAdd,
            this.btnEdit,
            this.btnRemove});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnSave
			// 
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(55, 22);
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(52, 22);
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPersonItem,
            this.tsAddressItem,
            this.tsPhoneItem,
            this.tsEmailItem});
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(59, 22);
			this.btnEdit.Text = "Edit";
			// 
			// tsPersonItem
			// 
			this.tsPersonItem.Image = ((System.Drawing.Image)(resources.GetObject("tsPersonItem.Image")));
			this.tsPersonItem.Name = "tsPersonItem";
			this.tsPersonItem.Size = new System.Drawing.Size(124, 22);
			this.tsPersonItem.Text = "Person";
			this.tsPersonItem.Click += new System.EventHandler(this.tsPersonItem_Click);
			// 
			// tsAddressItem
			// 
			this.tsAddressItem.Image = ((System.Drawing.Image)(resources.GetObject("tsAddressItem.Image")));
			this.tsAddressItem.Name = "tsAddressItem";
			this.tsAddressItem.Size = new System.Drawing.Size(124, 22);
			this.tsAddressItem.Text = "Address";
			this.tsAddressItem.Click += new System.EventHandler(this.tsAddressItem_Click);
			// 
			// tsPhoneItem
			// 
			this.tsPhoneItem.Image = ((System.Drawing.Image)(resources.GetObject("tsPhoneItem.Image")));
			this.tsPhoneItem.Name = "tsPhoneItem";
			this.tsPhoneItem.Size = new System.Drawing.Size(124, 22);
			this.tsPhoneItem.Text = "Phone";
			this.tsPhoneItem.Click += new System.EventHandler(this.tsPhoneItem_Click);
			// 
			// tsEmailItem
			// 
			this.tsEmailItem.Image = ((System.Drawing.Image)(resources.GetObject("tsEmailItem.Image")));
			this.tsEmailItem.Name = "tsEmailItem";
			this.tsEmailItem.Size = new System.Drawing.Size(124, 22);
			this.tsEmailItem.Text = "Email";
			this.tsEmailItem.Click += new System.EventHandler(this.tsEmailItem_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
			this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 22);
			this.btnRemove.Text = "Remove";
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// contactsDataGridView
			// 
			this.contactsDataGridView.AllowUserToAddRows = false;
			this.contactsDataGridView.AllowUserToDeleteRows = false;
			this.contactsDataGridView.AllowUserToResizeRows = false;
			this.contactsDataGridView.AutoGenerateColumns = false;
			this.contactsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.contactsDataGridView.BackgroundColor = System.Drawing.Color.Snow;
			this.contactsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.contactsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Thistle;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.contactsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.contactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.contactsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.contactsDataGridView.DataSource = this.contactsBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.contactsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.contactsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contactsDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
			this.contactsDataGridView.Location = new System.Drawing.Point(0, 25);
			this.contactsDataGridView.Margin = new System.Windows.Forms.Padding(5);
			this.contactsDataGridView.MultiSelect = false;
			this.contactsDataGridView.Name = "contactsDataGridView";
			this.contactsDataGridView.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.contactsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.contactsDataGridView.RowHeadersVisible = false;
			this.contactsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.contactsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.contactsDataGridView.Size = new System.Drawing.Size(1184, 486);
			this.contactsDataGridView.TabIndex = 1;
			this.contactsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsDataGridView_CellDoubleClick);
			this.contactsDataGridView.SelectionChanged += new System.EventHandler(this.contactsDataGridView_SelectionChanged);
			// 
			// personDataGridViewTextBoxColumn
			// 
			this.personDataGridViewTextBoxColumn.DataPropertyName = "Person";
			this.personDataGridViewTextBoxColumn.HeaderText = "Person";
			this.personDataGridViewTextBoxColumn.MinimumWidth = 250;
			this.personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
			this.personDataGridViewTextBoxColumn.ReadOnly = true;
			this.personDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 250;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.MinimumWidth = 250;
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 250;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			this.emailDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// contactsBindingSource
			// 
			this.contactsBindingSource.DataSource = typeof(WF_Phonebook.Models.Contact);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(1184, 511);
			this.Controls.Add(this.contactsDataGridView);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(1200, 550);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phonebook";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.contactsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnRemove;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.BindingSource contactsBindingSource;
		private System.Windows.Forms.ToolStripDropDownButton btnEdit;
		private System.Windows.Forms.ToolStripMenuItem tsPersonItem;
		private System.Windows.Forms.ToolStripMenuItem tsAddressItem;
		private System.Windows.Forms.ToolStripMenuItem tsPhoneItem;
		private System.Windows.Forms.ToolStripMenuItem tsEmailItem;
		private System.Windows.Forms.DataGridView contactsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
	}
}

