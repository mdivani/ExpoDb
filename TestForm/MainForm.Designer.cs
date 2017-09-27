namespace TestForm
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
            this.txtSqlType = new System.Windows.Forms.TextBox();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.lblSqlType = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.cbxTables = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.grdTable = new System.Windows.Forms.DataGridView();
            this.txtDtBaseName = new System.Windows.Forms.TextBox();
            this.lblDtName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSqlType
            // 
            this.txtSqlType.Location = new System.Drawing.Point(301, 26);
            this.txtSqlType.Name = "txtSqlType";
            this.txtSqlType.Size = new System.Drawing.Size(293, 20);
            this.txtSqlType.TabIndex = 0;
            // 
            // txtConnection
            // 
            this.txtConnection.Location = new System.Drawing.Point(301, 62);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(293, 20);
            this.txtConnection.TabIndex = 1;
            // 
            // lblSqlType
            // 
            this.lblSqlType.AutoSize = true;
            this.lblSqlType.Location = new System.Drawing.Point(200, 29);
            this.lblSqlType.Name = "lblSqlType";
            this.lblSqlType.Size = new System.Drawing.Size(80, 13);
            this.lblSqlType.TabIndex = 5;
            this.lblSqlType.Text = "Database Type";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(200, 65);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(84, 13);
            this.lblConnection.TabIndex = 6;
            this.lblConnection.Text = "DataConnection";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(200, 124);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(39, 13);
            this.lblTable.TabIndex = 7;
            this.lblTable.Text = "Tables";
            this.lblTable.Visible = false;
            // 
            // cbxTables
            // 
            this.cbxTables.FormattingEnabled = true;
            this.cbxTables.Location = new System.Drawing.Point(301, 121);
            this.cbxTables.Name = "cbxTables";
            this.cbxTables.Size = new System.Drawing.Size(293, 21);
            this.cbxTables.TabIndex = 8;
            this.cbxTables.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(480, 119);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(480, 148);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(114, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import table";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // grdTable
            // 
            this.grdTable.AllowUserToAddRows = false;
            this.grdTable.AllowUserToDeleteRows = false;
            this.grdTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTable.Location = new System.Drawing.Point(12, 177);
            this.grdTable.Name = "grdTable";
            this.grdTable.ReadOnly = true;
            this.grdTable.Size = new System.Drawing.Size(582, 288);
            this.grdTable.TabIndex = 11;
            this.grdTable.Visible = false;
            // 
            // txtDtBaseName
            // 
            this.txtDtBaseName.Location = new System.Drawing.Point(301, 95);
            this.txtDtBaseName.Name = "txtDtBaseName";
            this.txtDtBaseName.Size = new System.Drawing.Size(180, 20);
            this.txtDtBaseName.TabIndex = 12;
            // 
            // lblDtName
            // 
            this.lblDtName.AutoSize = true;
            this.lblDtName.Location = new System.Drawing.Point(200, 98);
            this.lblDtName.Name = "lblDtName";
            this.lblDtName.Size = new System.Drawing.Size(82, 13);
            this.lblDtName.TabIndex = 13;
            this.lblDtName.Text = "Database name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 469);
            this.Controls.Add(this.lblDtName);
            this.Controls.Add(this.txtDtBaseName);
            this.Controls.Add(this.grdTable);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbxTables);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.lblSqlType);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.txtSqlType);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSqlType;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label lblSqlType;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cbxTables;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridView grdTable;
        private System.Windows.Forms.TextBox txtDtBaseName;
        private System.Windows.Forms.Label lblDtName;
    }
}

