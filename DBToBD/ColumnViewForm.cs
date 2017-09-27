using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBToBD
{
    public partial class ColumnViewForm : Form
    {
        public ColumnViewForm()
        {

            InitializeComponent();
            dgvColumnData.AutoGenerateColumns = true;
        }

        public DataGridView DataGridSource
        {
            set
            {
                dgvColumnData.DataSource = value;
            }
            get
            {
                return dgvColumnData;
            }
        }
    }
}
