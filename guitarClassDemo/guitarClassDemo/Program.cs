using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitarClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitar myGuitar1 = new Guitar();

            myGuitar1.Strum();

            myGuitar1.RockOut();

            myGuitar1.About();
        }
    }

    public class Guitar
    {
        string make;
        string modelType;
        string color;
        int numberOfStrings;
        bool electric;

        public void Strum()
        {
            Console.WriteLine("Playback a pleasant chord.");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

        public void RockOut()
        {
            Console.WriteLine("This guitar rocks!!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }

        public void About()
        {
            Console.WriteLine("This guitar is made by: " + make);
            Console.WriteLine("The model is a: " + modelType);
            Console.WriteLine("It is {0} in color", color);
            Console.WriteLine("It features {0} strings.", numberOfStrings);
            
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}
