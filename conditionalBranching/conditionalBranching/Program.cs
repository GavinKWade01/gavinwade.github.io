using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalBranching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first and last name: ");

            string username = Console.ReadLine();

            Console.WriteLine("\nPlease enter your age:");

            int age = Convert.ToInt16(Console.ReadLine());
        }
    }
}
