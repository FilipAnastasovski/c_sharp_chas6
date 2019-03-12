using System;

namespace chas_6_vezba1
{
    class Program
    {

        static void CheckNum(double a)
        {
            if (a > 0)
            {
                Console.WriteLine("positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("negative");
            }

            if(a%2 == 0)
            {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }

            double d = a;
            bool isInt = d == (int)d;
            if (isInt)
            {
                Console.WriteLine("integer");
            }
            else { Console.WriteLine("decimal"); }

           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("insert number");

            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Stats for number:{num}");
            CheckNum(num);

            Console.ReadLine();

        }
    }
}
