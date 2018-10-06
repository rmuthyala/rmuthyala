using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCalculatorUsingIfElse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            string FN = Console.ReadLine();
            int X = int.Parse(FN);
            Console.WriteLine("Enter Second Number");
            string SN = Console.ReadLine();
            int Y = int.Parse(SN);
            Console.WriteLine("Choose your operator from (+, -, *, /, %");
            string Operator = Console.ReadLine();
            if(Operator == "+")
            {
                int Result = X + Y;
                Console.WriteLine("Resut is {0}", Result);
                Console.ReadLine();
            }
            else if (Operator == "-")
            {
                int Result = X - Y;
                Console.WriteLine("Resut is {0}", Result);
                Console.ReadLine();
            }
            else if (Operator == "*")
            {
                int Result = X * Y;
                Console.WriteLine("Resut is {0}", Result);
                Console.ReadLine();
            }
            else if (Operator == "/")
            {
                int Result = X / Y;
                Console.WriteLine("Resut is {0}", Result);
                Console.ReadLine();
            }
            else if (Operator == "%")
            {
                int Result = X % Y;
                Console.WriteLine("Resut is {0}", Result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                Console.ReadLine();
            }
        }
    }
}
