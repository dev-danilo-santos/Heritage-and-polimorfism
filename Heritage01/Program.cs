using System;
using Heritage01.Entities;

namespace Heritage01
{
    class Program
    {
        static void Main(string[] args)
        {

            Account Acc = new Account(1223, "Maria", 10000);
            BusinessAccount Bs = new BusinessAccount(1233, "Jhon",5000, 10000);

            //Upcasting
            Account Acc1 = Bs;
            Account Acc2 = new BusinessAccount(2233,"Max", 100000, 250000);
            Account Acc3 = new SavingsAccount(5,23455,"Jhenny", 50000);

            //downcasting 

            BusinessAccount acc4 = (BusinessAccount)Acc2;
            acc4.Loan(150000);
            Console.WriteLine(acc4.Balance);

            // não pode fazer isso -> BusinessAccount acc5 = acc3; vai gerar um erro em tempo de execução, pois 
            //não é possível converter de subclasse para subclasse.

            if (Acc3 is BusinessAccount) 
            {
                BusinessAccount acc5 = (BusinessAccount)Acc3;
                Console.WriteLine("é ");
            }

            Account c = new Account(2233434, "Lucas", 10000);
            SavingsAccount Sa = new SavingsAccount(1, 3443556, "Ana", 10000);

            c.Withdraw(1000);
            Sa.Withdraw(1000);

            Console.WriteLine(c.Balance);
            Console.WriteLine(Sa.Balance);

        }
    }
}
