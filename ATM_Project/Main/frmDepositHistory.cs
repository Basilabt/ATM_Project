using ATMBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Project.Main
{
    public partial class frmDepositHistory : Form
    {
        private DataTable _depositsDataTable;

        public frmDepositHistory()
        {
            InitializeComponent();
        }

        private void frmDepositHistory_Load(object sender, EventArgs e)
        {
            this._getDepositFromDB();

            this._fillDataGridViewWithData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _getDepositFromDB()
        {
            this._depositsDataTable = clsDeposit.getDeposits(clsGlobal.account.accountID);
        }

        private void _fillDataGridViewWithData()
        {
            this.dgvDeposits.DataSource = this._depositsDataTable;
        }

    }
}
