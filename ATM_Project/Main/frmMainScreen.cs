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
    public partial class frmMainScreen : Form
    {
        private clsAccount _account;

        public frmMainScreen(clsAccount account)
        {
            InitializeComponent();

            this._account = account;
        }


        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            this._setClinetName();
            this._setCurrentDateTime();
        }

        private void _setClinetName()
        {
            clsPerson person = this._account.client.person;

            this.lblClientName.Text = person.fullname.ToString();
        }

        private void _setCurrentDateTime()
        {
            lblCurrentDate.Text = DateTime.Now.ToString();
        }

        private void lblClientName_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            frmWithdrawScreen withdrawForm = new frmWithdrawScreen();
            withdrawForm.ShowDialog();



        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            frmDepsitScreen depositForm = new frmDepsitScreen();
            depositForm.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            clsGlobal.logout();
            this.Close();
        }

        private void brnWithdrawHistory_Click(object sender, EventArgs e)
        {
            frmWithdrawHistory from = new frmWithdrawHistory();
            from.ShowDialog();
        }

        private void btnDepositHistory_Click(object sender, EventArgs e)
        {
            frmDepositHistory form = new frmDepositHistory();
            form.ShowDialog();
        }
    }
}
