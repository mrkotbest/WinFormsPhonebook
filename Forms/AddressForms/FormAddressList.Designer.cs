namespace WF_Phonebook.Forms
{
	partial class FormAddressList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddressList));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnRemove = new System.Windows.Forms.ToolStripButton();
			this.addressListDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.addressListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnRemove});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(784, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
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
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(50, 22);
			this.btnEdit.Text = "Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
			// addressListDataGridView
			// 
			this.addressListDataGridView.AllowUserToAddRows = false;
			this.addressListDataGridView.AllowUserToDeleteRows = false;
			this.addressListDataGridView.AutoGenerateColumns = false;
			this.addressListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.addressListDataGridView.BackgroundColor = System.Drawing.Color.Snow;
			this.addressListDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.addressListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.addressListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.addressListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.addressListDataGridView.DataSource = this.addressListBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.addressListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.addressListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addressListDataGridView.Location = new System.Drawing.Point(0, 25);
			this.addressListDataGridView.Name = "addressListDataGridView";
			this.addressListDataGridView.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.addressListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.addressListDataGridView.RowHeadersVisible = false;
			this.addressListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.addressListDataGridView.Size = new System.Drawing.Size(784, 336);
			this.addressListDataGridView.TabIndex = 1;
			this.addressListDataGridView.SelectionChanged += new System.EventHandler(this.addressListDataGridView_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn1.HeaderText = "Street";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "HouseNo";
			this.dataGridViewTextBoxColumn2.HeaderText = "House Number";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ApartmentNo";
			this.dataGridViewTextBoxColumn3.HeaderText = "Apartment Number";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// addressListBindingSource
			// 
			this.addressListBindingSource.DataSource = typeof(WF_Phonebook.Models.Address);
			// 
			// FormAddressList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(784, 361);
			this.Controls.Add(this.addressListDataGridView);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormAddressList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Addresses";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddressList_FormClosed);
			this.Load += new System.EventHandler(this.FormAddressList_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.addressListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.addressListBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnRemove;
		private System.Windows.Forms.BindingSource addressListBindingSource;
		private System.Windows.Forms.DataGridView addressListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}