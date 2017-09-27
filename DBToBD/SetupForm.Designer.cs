namespace DBToBD
{
    partial class SetupForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.pntButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSqlTypes = new System.Windows.Forms.ComboBox();
            this.cmbAuthTypes = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSqlType = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblAuthType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pntButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pntButtons
            // 
            this.pntButtons.Controls.Add(this.btnConnect);
            this.pntButtons.Controls.Add(this.btnCancel);
            this.pntButtons.Location = new System.Drawing.Point(134, 173);
            this.pntButtons.Name = "pntButtons";
            this.pntButtons.Size = new System.Drawing.Size(232, 29);
            this.pntButtons.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(119, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(4, 30);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(225, 20);
            this.txtServerName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.cmbAuthTypes);
            this.panel1.Controls.Add(this.cmbSqlTypes);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 155);
            this.panel1.TabIndex = 3;
            // 
            // cmbSqlTypes
            // 
            this.cmbSqlTypes.FormattingEnabled = true;
            this.cmbSqlTypes.Location = new System.Drawing.Point(4, 3);
            this.cmbSqlTypes.Name = "cmbSqlTypes";
            this.cmbSqlTypes.Size = new System.Drawing.Size(225, 21);
            this.cmbSqlTypes.TabIndex = 3;
            // 
            // cmbAuthTypes
            // 
            this.cmbAuthTypes.FormattingEnabled = true;
            this.cmbAuthTypes.Location = new System.Drawing.Point(4, 57);
            this.cmbAuthTypes.Name = "cmbAuthTypes";
            this.cmbAuthTypes.Size = new System.Drawing.Size(225, 21);
            this.cmbAuthTypes.TabIndex = 4;
            this.cmbAuthTypes.DisplayMemberChanged += new System.EventHandler(this.cmbAuthTypes_DisplayMemberChanged);
            this.cmbAuthTypes.SelectedValueChanged += new System.EventHandler(this.cmbAuthTypes_SelectedValueChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(37, 97);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(37, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // lblSqlType
            // 
            this.lblSqlType.AutoSize = true;
            this.lblSqlType.Location = new System.Drawing.Point(13, 22);
            this.lblSqlType.Name = "lblSqlType";
            this.lblSqlType.Size = new System.Drawing.Size(61, 13);
            this.lblSqlType.TabIndex = 4;
            this.lblSqlType.Text = "Server type";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(13, 49);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(67, 13);
            this.lblServerName.TabIndex = 5;
            this.lblServerName.Text = "Server name";
            // 
            // lblAuthType
            // 
            this.lblAuthType.AutoSize = true;
            this.lblAuthType.Location = new System.Drawing.Point(13, 77);
            this.lblAuthType.Name = "lblAuthType";
            this.lblAuthType.Size = new System.Drawing.Size(52, 13);
            this.lblAuthType.TabIndex = 6;
            this.lblAuthType.Text = "Auth type";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(13, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(13, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // SetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 206);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblAuthType);
            this.Controls.Add(this.lblServerName);
            this.Controls.Add(this.lblSqlType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pntButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.pntButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pntButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbAuthTypes;
        private System.Windows.Forms.ComboBox cmbSqlTypes;
        private System.Windows.Forms.Label lblSqlType;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblAuthType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
    }
}