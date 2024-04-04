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

using System.Diagnostics;
using ATM_Project.Main;

namespace ATM_Project
{
    public partial class frmLoginScreen : Form
    {
        private enum enLoginAttemptResult
        {
            Succesfull = 1 , FailedToLogin = 0
        }

        public frmLoginScreen()
        {
            InitializeComponent();
        }




        private enLoginAttemptResult _login()
        {

            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text.Trim();


            clsAccount account = clsAccount.findByUsernameAndPassword(username, password);

            if (account == null)
            {
                return enLoginAttemptResult.FailedToLogin;
            }

            clsGlobal.account = account;
            

            return enLoginAttemptResult.Succesfull;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            enLoginAttemptResult result = this._login();

            switch (result)
            {

                case enLoginAttemptResult.Succesfull:
                    {
                        this._clearLoginFields();
                        frmMainScreen form = new frmMainScreen(clsGlobal.account);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();

                        break;
                    }

                case enLoginAttemptResult.FailedToLogin:
                    {
                        MessageBox.Show("Failed To Login", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }


            }
        }

        private void _clearLoginFields()
        {
            this.txtboxUsername.Text = "";
            this.txtboxPassword.Text = "";
        }
    }
}
