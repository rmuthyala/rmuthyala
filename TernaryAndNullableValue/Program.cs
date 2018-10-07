using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryAndNullableValue
{
    class Program
    {
        static void Main()
        {
            int Number = 20;
            bool Result = Number == 10 ? true : false;
            Console.WriteLine("Result is {0}", Result);

            //if (Number == 20)
            //{
            //    Result = true;
            //    Console.WriteLine("Number == 20 is {0}", Result);
            //}
            //else
            //{
            //    Result = false;
            //    Console.WriteLine(Result);
            //}
        }
    }
}
