using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCalculatorUsingSwitchStatement
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
            int Result = 0;
            switch(Operator)
            {
                case "+":
                    Result = X + Y;
                    Console.WriteLine("Result is {0}", Result);
                    Console.ReadLine();
                    break;

                case "-":
                    Result = X - Y;
                    Console.WriteLine("Result is {0}", Result);
                    Console.ReadLine();
                    break;
                case "*":
                    Result = X * Y;
                    Console.WriteLine("Result is {0}", Result);
                    Console.ReadLine();
                    break;
                case "/":
                    Result = X / Y;
                    Console.WriteLine("Result is {0}", Result);
                    Console.ReadLine();
                    break;
                case "%":
                    Result = X % Y;
                    Console.WriteLine("Result is {0}", Result);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
