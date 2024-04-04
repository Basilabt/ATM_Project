using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusiness
{
    public class clsGlobal
    {

        public static clsAccount account;

        public static double maxAmountToWithdrawPerTime = 2000;

        public static void logout()
        {
            account = null;
        }

    }
}
