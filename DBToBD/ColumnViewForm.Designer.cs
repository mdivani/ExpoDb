namespace DBToBD
{
    partial class ColumnViewForm
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
            this.dgvColumnData = new System.Windows.Forms.DataGridView();
            this.cntxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnData)).BeginInit();
            this.cntxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvColumnData
            // 
            this.dgvColumnData.AllowUserToAddRows = false;
            this.dgvColumnData.AllowUserToDeleteRows = false;
            this.dgvColumnData.AllowUserToResizeColumns = false;
            this.dgvColumnData.AllowUserToResizeRows = false;
            this.dgvColumnData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColumnData.Location = new System.Drawing.Point(0, 0);
            this.dgvColumnData.Name = "dgvColumnData";
            this.dgvColumnData.Size = new System.Drawing.Size(358, 429);
            this.dgvColumnData.TabIndex = 0;
            // 
            // cntxMenu
            // 
            this.cntxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.cntxMenu.Name = "cntxMenu";
            this.cntxMenu.Size = new System.Drawing.Size(106, 26);
            this.cntxMenu.Text = "Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ColumnViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 429);
            this.Controls.Add(this.dgvColumnData);
            this.Name = "ColumnViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View data";
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumnData)).EndInit();
            this.cntxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColumnData;
        private System.Windows.Forms.ContextMenuStrip cntxMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
    }
}