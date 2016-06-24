using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {

        static void NamePet()
        {
            
            Console.WriteLine("Enter the name of your pet.");
            string petName = Console.ReadLine();

        }
        static void Main(string[] args)
        {

            /*Methods called in Program
            Tick how often to call tick. Not neccesarrily time. could be Looped and tied to other methods
            Feed
            water
            play
            rest
            do nothing

           */
            Console.WriteLine("Welcome to Virtual Pet");
            VPet myPet = new VPet();
            myPet.Name = Console.ReadLine();
            NamePet();
        }
    }
}
