using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Account
    {
        private protected float balance;

        public float Getbalance() { return balance; }
    }
    internal class SavingsAccount : Account
    {
        private protected SavingsAccount(float NewBalance)
        {
            balance = NewBalance;
        }
    }
}
