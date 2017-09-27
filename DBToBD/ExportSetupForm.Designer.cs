namespace DBToBD
{
    partial class ExportSetupForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblDatabases = new System.Windows.Forms.Label();
            this.lblTables = new System.Windows.Forms.Label();
            this.btnImportedData = new System.Windows.Forms.Button();
            this.lbImportedColumns = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(515, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(97, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // lblDatabases
            // 
            this.lblDatabases.AutoSize = true;
            this.lblDatabases.Location = new System.Drawing.Point(27, 15);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Size = new System.Drawing.Size(58, 13);
            this.lblDatabases.TabIndex = 3;
            this.lblDatabases.Text = "Databases";
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(27, 42);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(39, 13);
            this.lblTables.TabIndex = 4;
            this.lblTables.Text = "Tables";
            // 
            // btnImportedData
            // 
            this.btnImportedData.Location = new System.Drawing.Point(97, 66);
            this.btnImportedData.Name = "btnImportedData";
            this.btnImportedData.Size = new System.Drawing.Size(157, 23);
            this.btnImportedData.TabIndex = 5;
            this.btnImportedData.Text = "View imported data";
            this.btnImportedData.UseVisualStyleBackColor = true;
            this.btnImportedData.Click += new System.EventHandler(this.btnImportedData_Click);
            // 
            // lbImportedColumns
            // 
            this.lbImportedColumns.FormattingEnabled = true;
            this.lbImportedColumns.Location = new System.Drawing.Point(97, 95);
            this.lbImportedColumns.Name = "lbImportedColumns";
            this.lbImportedColumns.Size = new System.Drawing.Size(157, 121);
            this.lbImportedColumns.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(179, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ExportSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 399);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbImportedColumns);
            this.Controls.Add(this.btnImportedData);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.lblDatabases);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Name = "ExportSetupForm";
            this.Text = "Export Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Button btnImportedData;
        private System.Windows.Forms.ListBox lbImportedColumns;
        private System.Windows.Forms.Button btnAdd;
    }
}