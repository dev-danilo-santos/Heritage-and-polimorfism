using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage01.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(double interestRate, int number, string holder, double balance) 
        : base(number, holder,balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double value)
        {
            if (value <= Balance && value > 0)
            {
                Balance -= value;
                Console.WriteLine($"Withdray {value}");
            }
            else if (value < 0) { Console.WriteLine("The value it can not be negative! "); }
            else if (value > Balance)
            {
                Console.WriteLine("The value is greater than avaiable! ");
            }

        }

    }
}
