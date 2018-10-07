using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("ENter you first name");
            string FN = Console.ReadLine();
            Console.WriteLine("Enter you last name");
            string LN = Console.ReadLine();
            Console.WriteLine("Are you major");
            bool? Answer = null;
            if (Answer == true)
            {
                Console.WriteLine("User is major");
            }
            else if(Answer==false)
            {
                Console.WriteLine("User is not major");
            }
            else
            {
                Console.WriteLine("User did not answer");
            }
        }
    }
}
