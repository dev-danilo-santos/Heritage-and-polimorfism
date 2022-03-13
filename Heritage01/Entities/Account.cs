using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage01.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }
        
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public Account()
        {

        }

        public virtual void Withdraw(double value) 
        {
            if (value <= Balance && value > 0) {
                Balance -= value + 5;
                Console.WriteLine($"Withdray {value}");
            }
            else if (value < 0) { Console.WriteLine("The value it can not be negative! "); }
            else if (value > Balance)
            {
                Console.WriteLine("The value is greater than avaiable! ");
            }

        }

        public void Deposit(double value)
        {
            if (value < 0) { Balance += value; }
            else { Console.WriteLine("The value must be greather than zero"); }
        }

    }
}
