using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db.Domain;
using DbToDb.Core;

namespace DBToBD
{
    public partial class MainForm : Form
    {
        private ImportSetup _setup;
        private List<ColumnInfo> _columInfoList;
        private BindingList<string> _importedColumnNames;
        ColumnViewForm ColumnView;
        ColumnViewForm TableView;

        public MainForm(ImportSetup Setup)
        {
            try
            {
                _setup = Setup;
                InitializeComponent();
                _importedColumnNames = new BindingList<string>();
                this.LoadDatabases();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void LoadDatabases()
        {
            cbDatabases.DataSource = _setup.Databases;
        }

        private void cbDatabases_SelectedValueChanged(object sender, EventArgs e)
        {
            cbTables.DataSource = _setup.GetTableNames(cbDatabases.SelectedItem.ToString());
        }

        private void cbTables_SelectedValueChanged(object sender, EventArgs e)
        {
            _columInfoList = _setup.GetColumnsList(cbTables.SelectedItem.ToString(), cbDatabases.SelectedItem.ToString());
            cbColumns.DataSource = _columInfoList.Select(x => x.ColumnName).ToList();
        }

        private void btnShowColumns_Click(object sender, EventArgs e)
        {
            ColumnView.Show();
        }

        private void AddColumnToImportList()
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            ColumnView = new ColumnViewForm();
            var column = _columInfoList[cbColumns.SelectedIndex];
            _setup.ImportColumnData(column);
            dgvImportedTable.DataSource = ColumnView.DataGridSource.DataSource = _setup.GetImportedData;
            lbImportedColumns.DataSource = _importedColumnNames;
            _importedColumnNames.Add(column.ColumnName);
            btnExport.Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TableView = new ColumnViewForm();
            TableView.DataGridSource.DataSource = _columInfoList;
            TableView.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SetupForm ExSetup = new SetupForm();
            ExSetup.ShowDialog();
            if (ExSetup.Connect)
            {
                ExportSetup exSetup = ExSetup.ExportSetupObject;
                ExportSetupForm exportForm = new ExportSetupForm(_setup.GetImportedData, exSetup);
                exportForm.ShowDialog();
            }
        }
    }
}
