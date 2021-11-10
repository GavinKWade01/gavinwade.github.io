using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "For Loop Demo";

            for (int i = 0; i <11; i++)
            {
                Console.WriteLine("The value of i is: {0}", i);
            }
            Console.WriteLine("The value of i is too high to keep running.");
            Console.ReadLine();
            Console.Clear();


            for (int j = 10; j > -1; j--)
            {
                Console.WriteLine("The value of j is: {0}", j);
            }
            Console.WriteLine("The value of j is too low to keep running.");
            Console.ReadLine();
            Console.Clear();


        }
    }
}
