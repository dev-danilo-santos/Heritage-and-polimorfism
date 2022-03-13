﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage01.Entities
{
        sealed class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        
        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount<= LoanLimit) { base.Balance += amount; }
            else { Console.WriteLine($"Refused, your limit is {LoanLimit}"); }
        }
    }
}
