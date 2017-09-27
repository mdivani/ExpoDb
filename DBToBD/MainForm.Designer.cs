namespace DBToBD
{
    partial class MainForm
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
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lblDatabases = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.btnShowColumns = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.dgvImportedTable = new System.Windows.Forms.DataGridView();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lbImportedColumns = new System.Windows.Forms.ListBox();
            this.lblImportedListBox = new System.Windows.Forms.Label();
            this.btnViewColumn = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(73, 22);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(186, 21);
            this.cbDatabases.TabIndex = 4;
            this.cbDatabases.SelectedValueChanged += new System.EventHandler(this.cbDatabases_SelectedValueChanged);
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(73, 62);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(186, 21);
            this.cbTables.TabIndex = 5;
            this.cbTables.SelectedValueChanged += new System.EventHandler(this.cbTables_SelectedValueChanged);
            // 
            // lblDatabases
            // 
            this.lblDatabases.AutoSize = true;
            this.lblDatabases.Location = new System.Drawing.Point(10, 25);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Size = new System.Drawing.Size(58, 13);
            this.lblDatabases.TabIndex = 6;
            this.lblDatabases.Text = "Databases";
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(10, 65);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(39, 13);
            this.lblTables.TabIndex = 7;
            this.lblTables.Text = "Tables";
            // 
            // btnShowColumns
            // 
            this.btnShowColumns.Location = new System.Drawing.Point(73, 160);
            this.btnShowColumns.Name = "btnShowColumns";
            this.btnShowColumns.Size = new System.Drawing.Size(186, 23);
            this.btnShowColumns.TabIndex = 8;
            this.btnShowColumns.Text = "All Column Values";
            this.btnShowColumns.UseVisualStyleBackColor = true;
            this.btnShowColumns.Visible = false;
            this.btnShowColumns.Click += new System.EventHandler(this.btnShowColumns_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(73, 131);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 23);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(169, 355);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(73, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(170, 131);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(89, 23);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // dgvImportedTable
            // 
            this.dgvImportedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportedTable.Location = new System.Drawing.Point(265, 22);
            this.dgvImportedTable.Name = "dgvImportedTable";
            this.dgvImportedTable.Size = new System.Drawing.Size(647, 492);
            this.dgvImportedTable.TabIndex = 15;
            // 
            // cbColumns
            // 
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(73, 104);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(186, 21);
            this.cbColumns.TabIndex = 16;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(10, 107);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 17;
            this.lblColumns.Text = "Columns";
            // 
            // lbImportedColumns
            // 
            this.lbImportedColumns.FormattingEnabled = true;
            this.lbImportedColumns.Location = new System.Drawing.Point(73, 215);
            this.lbImportedColumns.Name = "lbImportedColumns";
            this.lbImportedColumns.Size = new System.Drawing.Size(186, 134);
            this.lbImportedColumns.TabIndex = 18;
            // 
            // lblImportedListBox
            // 
            this.lblImportedListBox.AutoSize = true;
            this.lblImportedListBox.Location = new System.Drawing.Point(72, 199);
            this.lblImportedListBox.Name = "lblImportedListBox";
            this.lblImportedListBox.Size = new System.Drawing.Size(91, 13);
            this.lblImportedListBox.TabIndex = 19;
            this.lblImportedListBox.Text = "Imported Columns";
            // 
            // btnViewColumn
            // 
            this.btnViewColumn.Enabled = false;
            this.btnViewColumn.Location = new System.Drawing.Point(73, 385);
            this.btnViewColumn.Name = "btnViewColumn";
            this.btnViewColumn.Size = new System.Drawing.Size(186, 23);
            this.btnViewColumn.TabIndex = 20;
            this.btnViewColumn.Text = "View Column Values";
            this.btnViewColumn.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(822, 520);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(90, 23);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 548);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnViewColumn);
            this.Controls.Add(this.lblImportedListBox);
            this.Controls.Add(this.lbImportedColumns);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.cbColumns);
            this.Controls.Add(this.dgvImportedTable);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnShowColumns);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.lblDatabases);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.cbDatabases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Button btnShowColumns;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.DataGridView dgvImportedTable;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.ListBox lbImportedColumns;
        private System.Windows.Forms.Label lblImportedListBox;
        private System.Windows.Forms.Button btnViewColumn;
        private System.Windows.Forms.Button btnExport;
    }
}

