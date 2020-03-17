using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        class BankAccount
        {
            private int _id;
            private decimal _balance = 0;
            // Public 
            public int Id;
            public decimal Balance = 0;
            public BankAccount(int id, decimal balance)
            {
                _id = id;
                _balance = balance;
            }

            public void Print()
            {
                Console.WriteLine("The ID: " + _id);
                Console.WriteLine("The balance: " + _balance);

            }

            public void Deposit(decimal deposit)
            {
                _balance = _balance + deposit;
                Console.WriteLine("Sent: " + deposit);
                Console.WriteLine("Current amount in the account: " + _balance);
            }

            public void Withdraw(decimal withdraw)
            {
                _balance = _balance - withdraw;
                Console.WriteLine("Withdraw: " + withdraw);
                Console.WriteLine("Current amount in the account: " + _balance);

                if (!IsBalanceGreaterThanZero())
                {
                    _balance = 0;
                    Console.WriteLine("Your Account is Empty");
                }
            }

            public bool IsBalanceGreaterThanZero()
            {
                return _balance >= 0;
            }

            static void Main(string[] args)
            {
                BankAccount acc = new BankAccount(1, 15);
                acc.Print();
                acc.Deposit(15);
                acc.Withdraw(10);
            }
        }
    }
 