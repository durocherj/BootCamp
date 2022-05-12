using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftFee { get; set; }

        public override bool WithdrawMoney(decimal amount)
        {
            if(OverdraftFee > 0)
            {
                Console.WriteLine("Sorry, you have an overdraft.");
                return false;
            }
            else
            {
                Balance -= amount;
                Console
            }
        }
    }
}
