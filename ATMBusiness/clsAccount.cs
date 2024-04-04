using ATMDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsAccount
    {
        public enum enAction
        {
            Withdraw = 1 , Deposit = 2 
        }

        public enum enActionResult
        {
            Succesfull = 1 , NoSufficientBalance = 2 , ExceedsTheMaxWithdrawalAmount = 3 , UnknownErrorOcurred = 4
        }

        public int accountID { set; get; }
        public int clientID { set; get; }
        public double balance { set; get; }
        public string username { set; get; }
        public string password { set; get; }
        public bool isActive { set; get; }

        // Composition
        public clsClient client;

        clsAccount()
        {
            this.accountID = -1;
            this.clientID = -1;
            this.balance = -1;  
            this.username = "";
            this.password = "";
            this.isActive = false;
        }

        private clsAccount(int accountID, int clientID, double balance, string username, string password, bool isActive)
        {
            this.accountID = accountID;
            this.clientID = clientID;
            this.balance = balance;
            this.username = username;
            this.password = password;
            this.isActive = isActive;
            this.client = clsClient.findClientByID(clientID);

        }

        // Methods

        public enActionResult performAction(double amount , enAction action)
        {

            if(action == enAction.Withdraw && !this._checkIfAccountBalanceIsSufficient(amount))
            {
                return enActionResult.NoSufficientBalance;
            }

            if(action == enAction.Withdraw && amount > clsGlobal.maxAmountToWithdrawPerTime)
            {
                return enActionResult.ExceedsTheMaxWithdrawalAmount;
            }
            
            
            switch(action)
            {
                case enAction.Deposit:
                    {
                        return (clsAccountDataAccess.deposit(accountID, amount)) ? enActionResult.Succesfull : enActionResult.UnknownErrorOcurred ;
                    }

                case enAction.Withdraw:
                    {
                        return (clsAccountDataAccess.withdraw(accountID, amount)) ? enActionResult.Succesfull : enActionResult.UnknownErrorOcurred;
                        
                    }

            }

            return enActionResult.UnknownErrorOcurred;
        }

        private bool _checkIfAccountBalanceIsSufficient(double amount)
        {
            return this.balance >= amount;
        }

        public bool updateBalance()
        {
            double newBalance = 0;

            if(clsAccountDataAccess.getBalance(this.accountID,ref newBalance))
            {
                Console.WriteLine("DEBUG: New Balance = {0}", newBalance);
                this.balance = newBalance;
                return true;
            }

            return false;
        }

        // Static Methods

        public static clsAccount findByUsernameAndPassword(string username , string password)
        {
            int accountID = 0 , clientID = 0 ;
            double balance = 0 ;
            bool isActive = false;

            if(clsAccountDataAccess.findByUsernameAndPassword(username,password,ref accountID,ref clientID,ref balance,ref isActive))
            {   
                return new clsAccount(accountID,clientID,balance,username,password,isActive);
            }

            return null;
        }
    }
}
