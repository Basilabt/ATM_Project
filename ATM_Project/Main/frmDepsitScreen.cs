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
    public partial class frmDepsitScreen : Form
    {
        public frmDepsitScreen()
        {
            InitializeComponent();
        }


        private void frmDepsitScreen_Load(object sender, EventArgs e)
        {
            this._setLabels();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            this._deposit();

        }

        private void _setLabels()
        {
            lblAccountBalance.Text = clsGlobal.account.balance.ToString();
        }

        private void _deposit()
        {

            double amount = Convert.ToDouble(txtboxAmount.Text.ToString());

            clsAccount.enActionResult result = clsGlobal.account.performAction(amount, clsAccount.enAction.Deposit);

            switch (result)
            {

                case clsAccount.enActionResult.Succesfull:
                    {   
                        
                        clsGlobal.account.updateBalance();
                        clsDeposit.logDeposit(amount);
                        this._setLabels();
                        MessageBox.Show(String.Format("Succesfull, New Balance Is: {0}", clsGlobal.account.balance), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case clsAccount.enActionResult.NoSufficientBalance:
                    {
                        MessageBox.Show("No sufficient balance", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    }

                case clsAccount.enActionResult.ExceedsTheMaxWithdrawalAmount:
                    {
                        MessageBox.Show(String.Format("Can't withdraw more than {0} at a time", clsGlobal.maxAmountToWithdrawPerTime), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                case clsAccount.enActionResult.UnknownErrorOcurred:
                    {
                        MessageBox.Show("An Error Ocurred !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }



            }

            this.Close();

        }

    }
}
