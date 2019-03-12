using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chas_6_vezba2
{
    class Program
    {
        static void LogIn(string name, string password, User[] users)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 1000000);

            foreach (var user in users )
            {
                if((name == user.UserName)&&(password == user.Password))
                {
                    Console.WriteLine($"Welcome {name} here are your messages:");
                    Console.WriteLine(users[0].Messages[0]);
                    Console.WriteLine(users[0].Messages[1]);

                    Console.ReadLine();

                }
                else { Console.WriteLine("Pogreshni informacii"); }

                break;
            }
        }
     

        static void Register(string name, string pass, User[] users)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 1000000);

            Array.Resize(ref users, users.Length+1);
            users[users.Length - 1] = new User(random, name,pass);

            Console.WriteLine($"Added {name} to other users with Id:{random}");

            foreach(var user in users)
            {
                Console.WriteLine($" ID:{user.Id} USER:{user.UserName}");
            }

        }

        static void Main(string[] args)
        {

            User[] users = new User[]{

                new User(11, "Petar", "abcd"),
                new User(22, "Bob", "1234"),
                new User(33, "Gogo", "12qw")

            };

            Console.WriteLine("Log in OR Register?(1 or 2)");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Console.WriteLine("Enter name:");
                string nameInput1 = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string passInput1 = Console.ReadLine();

                LogIn(nameInput1, passInput1, users);

            }else if(choice == 2)
            {
                Console.WriteLine("Enter name:");
                string nameInput2 = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string passInput2 = Console.ReadLine();

                Register(nameInput2, passInput2, users);

            }
            else { Console.WriteLine("nema takov izbor"); }

            Console.ReadLine();
        }
    }
}


//////////
using System;
using System.Collections.Generic;
using System.Text;

namespace chas_6_vezba2
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string pass)
        {
            UserName = name;
            Password = pass;
            Id = id;

        }

        public string[] Messages { get; set; } = new string[] { "hello", "potato", "bro talk", "games talk" };
    }
}

