using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class Bank
    {

        public int Deposit(int amount, int totalamount)
        {

            return amount + totalamount;
        }

        public int Withdraw(int amount, int totalamount)
        {
            return totalamount - amount;
        }
    }
}