using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public decimal Balance { get; private set; }
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(Math.Abs(value - balance) <= 500)
                {
                    balance = value;
                    Console.WriteLine("Yeni bakiye : " + balance);
                }

            }
        }

        public Account(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            balance = 2000;
        }


        //public void Withdraw(decimal amount)
        //{
        //    if(Balance - amount >= 0)
        //    {
        //        Balance -= amount;
        //        Console.WriteLine("Çekilen tutar : " + amount);
        //    }
        //    else
        //        Console.WriteLine("Yetersiz bakiye");

        //}
    }
}
