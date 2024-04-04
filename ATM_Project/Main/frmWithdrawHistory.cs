using ATMBusiness;
using ATMDataAccess;
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
    public partial class frmWithdrawHistory : Form
    {
        private DataTable _withdrawsDataTable;

        public frmWithdrawHistory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWithdrawHistory_Load(object sender, EventArgs e)
        {
            this._getWithdrawsFromDB();

            this._fillDataGridViewWithData();
        }


        private void _getWithdrawsFromDB()
        {
            this._withdrawsDataTable = clsWithdraw.getWithdraws(clsGlobal.account.accountID);

        }

        private void _fillDataGridViewWithData()
        {
            this.dgvWithdraws.DataSource = this._withdrawsDataTable;   
        }
    }
}
