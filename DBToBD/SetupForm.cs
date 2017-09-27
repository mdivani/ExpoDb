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
    public partial class SetupForm : Form
    {
        private ConnectionTypes _selectedSQLType;
        private AuthTypes _selectedAuthType;
        private string _serverName;
        private string _user;
        private string _password;
        private bool _connect = false;
        private ImportSetup _setup;

        public SetupForm()
        {
            InitializeComponent();
            this.LoadComboBoxes();
        }

        public ConnectionTypes SelectedSQLType
        {
            get
            {
                return _selectedSQLType;
            }
        }

        public AuthTypes SelectedAuthType
        {
            get
            {
               return _selectedAuthType;
            }
        }

        public string ConnectionString
        {
            get
            {
                if (_selectedAuthType == AuthTypes.WindowsAuthentication)
                {
                    return "Data Source='" + _serverName + "';Integrated Security=True;";
                }
                else return "Data Source='" + _serverName + "';uid='" + _user + "';pwd='" +_password + "';";
            }
        }

        public bool Connect
        {
            get
            {
                return _connect;
            }
        }

        public ImportSetup ImportSetupObject
        {
            get
            {
                return _setup;
            }
        }

        public ExportSetup ExportSetupObject
        {
            get
            {
                return new ExportSetup(ConnectionString, SelectedSQLType);
            }
        }

        private void LoadComboBoxes()
        {
            cmbSqlTypes.DataSource = Enum.GetValues(typeof(ConnectionTypes));
            cmbAuthTypes.DataSource = Enum.GetValues(typeof(AuthTypes));
            cmbSqlTypes.SelectedItem = ConnectionTypes.MSSQL;
            cmbAuthTypes.SelectedItem = AuthTypes.WindowsAuthentication;
            this.ToggleUser();
        }

        private void ToggleUser()
        {
            AuthTypes selectedType = (AuthTypes)cmbAuthTypes.SelectedItem;
            txtPassword.Visible = lblPassword.Visible = txtUserName.Visible =
            lblUser.Visible = selectedType == AuthTypes.SQLServerAuthentication;
        }

        private void cmbAuthTypes_DisplayMemberChanged(object sender, EventArgs e)
        {
            this.ToggleUser();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm())
            {
                _selectedSQLType = (ConnectionTypes)cmbSqlTypes.SelectedItem;
                _selectedAuthType = (AuthTypes)cmbAuthTypes.SelectedItem;
                _serverName = txtServerName.Text;
                _user = txtUserName.Text;
                _password = txtPassword.Text;
                this.SetupConnection();
                if (_connect)
                {
                this.Close();
                }
            }
        }

        private bool ValidateForm()
        {
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _connect = false;
            this.Close();
        }

        private void cmbAuthTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ToggleUser();
        }

        private ImportSetup SetupConnection()
        {
            try
            {
                _setup = new ImportSetup(ConnectionString, SelectedSQLType);
                _connect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _connect = false;
            }
            return _setup;
        }
    }
}
