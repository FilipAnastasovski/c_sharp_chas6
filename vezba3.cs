using System;

namespace chas_6_vezba3
{
    class Program
    {


        static void CheckBalance(int money)
        {
            Console.WriteLine($"you have {money} left");
            
        }

        static void CashWithdrawal()
        {


        }

        static void CashDeposit()
        {

        }
        

        static void Main(string[] args)
        {
            Customer[] users = new Customer[]{

                new Customer("1234-1234-1234-1234", "Bob", "Bobsky", 4325, 500),
                new Customer("4321-4321-4321-4321", "Petar", "Petrovski", 1234, 1000),
                new Customer("0987-0987-0987-0987", "Ivan", "Ivanovski", 0987, 100)

            };

            Console.WriteLine("Please enter your card numer:");
            string cardNumInput = Console.ReadLine();

            foreach(var user in users)
            {
                if(cardNumInput == user.CardNum)
                {
                    Console.WriteLine("Please enter pin:");
                    int pinInput = int.Parse(Console.ReadLine());

                    if(pinInput == user.Pin)
                    {
                        Console.WriteLine($"Welcome {user.Name} {user.LastName} ");

                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("\n");
                        Console.WriteLine("1. Check Balance");
                        Console.WriteLine("2. Cash Withdrawal");
                        Console.WriteLine("3. Cash Deposit");

                        int desire = int.Parse(Console.ReadLine());

                        if(desire == 1)
                        {
                            CheckBalance(user.Cash);
                        }else if (desire == 2)
                        {
                            CashWithdrawal();
                        }else if (desire == 3)
                        {
                            CashDeposit();
                        }
                        else { Console.WriteLine("nema takov izbor"); }
                    }
                    else { Console.WriteLine("wrong pin number"); }
                }
                else { Console.WriteLine("unknown card number"); }
                break;
            }

            


            Console.ReadLine();
        }
    }
}

//////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace chas_6_vezba3
{
    class Customer
    {

        public string CardNum { get; set; }
        public int Pin { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Cash { get; set; }
      

        public Customer(string cardN, string name, string lastN, int pin, int money)
        {
            Name = name;
            LastName = lastN;
            CardNum = cardN;
            Pin = pin;
            Cash = money;

        }

    }
}
