using DbToDb.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;
using Db.Domain;

namespace TestForm
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();


        }

      private void btnConnect_Click(object sender, EventArgs e)
        {
            //try
            //{
            //  SetUpConnection();
            //    var tables = dtConn.;
            //    cbxTables.DataSource = tables;
            //    btnConnect.Visible = false;
            //    btnImport.Visible = true;
            //    cbxTables.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("data connection Error: " + ex.Message);
            //}
        }

        private void SetUpConnection()
        {
            //dtConn = new DataConnection(conn, txtConnection.Text, txtDtBaseName.Text);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string column = cbxTables.SelectedItem.ToString();
            //    dtConn.TableColumnName = column;
            //    var columns = dtConn.GetColumnNames();
            //    grdTable.DataSource = columns;
            //    grdTable.Visible = true;
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void test()
        {
           //var test = InformationSchema.ExportTable(conn);
           // MessageBox.Show(test);
        } 
    }
}
