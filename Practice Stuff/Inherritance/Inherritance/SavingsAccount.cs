using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public override bool WithdrawMoney(decimal amount)
        {
            //Works exactly like the parent class method
            return base.WithdrawMoney(amount);
        }
    }
}
