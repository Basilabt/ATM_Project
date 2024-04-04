using ATMDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsDeposit
    {
        public int depositID { get; }
        public int accountID { set; get; }
        public double amount { set; get; }
        public DateTime date { set; get; }

        public clsDeposit()
        {
            this.depositID = -1;
            this.accountID = -1;
            this.amount = 0;
            date = DateTime.Now;
        }

        private clsDeposit(int withdrawID, int accountID, double amount, DateTime date)
        {
            this.depositID = withdrawID;
            this.accountID = accountID;
            this.amount = amount;
            this.date = date;
        }

        public static void logDeposit(double amount)
        {
            clsDepositDataAccess.logDeposit(clsGlobal.account.accountID, amount, DateTime.Now);
        }

        public static DataTable getDeposits(int accountID)
        {
            return clsDepositDataAccess.getAllDeposits(accountID);
        }




    }
}
