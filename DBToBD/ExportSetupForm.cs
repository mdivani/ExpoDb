using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbToDb.Core;

namespace DBToBD
{
    public partial class ExportSetupForm : Form
    {

        private ExportSetup _setup;
        private ColumnViewForm _viewForm;
        private BindingList<string> _columnNamesList;
        public ExportSetupForm(DataTable importedColumnData, ExportSetup setup)
        {
            InitializeComponent();
            _columnNamesList = new BindingList<string>();
            _setup = setup;
            _viewForm = new ColumnViewForm();
            _viewForm.DataGridSource.DataSource = importedColumnData;
            lbImportedColumns.DataSource = GetColumnNames(importedColumnData.Columns);
        }

        private void btnImportedData_Click(object sender, EventArgs e)
        {
            _viewForm.Show();
        }

        private BindingList<string> GetColumnNames(DataColumnCollection columns)
        {
            foreach (DataColumn column in columns)
            {
                _columnNamesList.Add(column.ColumnName);
            }
            return _columnNamesList;
        }
    }
}
