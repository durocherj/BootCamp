using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public virtual bool WithdrawMoney(decimal amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("I'm sorry, there's not enough in your account.");
                return false;
            }
                
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful! Your new balance is ${Balance}.");
                return true;
            }
                
        }
    }
}
