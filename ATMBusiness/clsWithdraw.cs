using ATMDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsWithdraw
    {
        public int withdrawID {  get; }
        public int accountID { set; get; }
        public double amount { set; get; }
        public DateTime date { set; get; }

        public clsWithdraw()
        {
            this.withdrawID = -1;
            this.accountID = -1;
            this.amount = 0;
            date = DateTime.Now;
        }

        private clsWithdraw(int withdrawID , int accountID , double amount , DateTime date)
        {
            this.withdrawID = withdrawID;
            this.accountID = accountID;
            this.amount = amount;
            this.date = date;
        }

        public static void logWithdraw(double amount)
        {
            clsWithdrawDataAccess.LogWithdraw(clsGlobal.account.accountID,amount,DateTime.Now);
        }

        public static DataTable getWithdraws(int accountID)
        {
            return clsWithdrawDataAccess.getWithdraws(accountID);
        }

    }
}
