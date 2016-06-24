using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
       static VPet myPet = new VPet();

        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("To feed your pet press 1\n");
                Console.WriteLine("To do some thirst quenching press 2\n");
                Console.WriteLine("To play with your pet press 3\n");

                int choice = int.Parse(Console.ReadLine());
                 
                if (choice == 1)
                {
                    myPet.Feed();  
                }

                if (choice == 2)
                {
                    //drink()
                }

                if (choice == 3)
                {
                    //play()
                }
                else break;
            }
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
            Console.WriteLine("Welcome to Virtual Pet\n");
            
           // VPet myPet = new VPet(); uneeded
            Console.WriteLine("Enter in a name for your new pet!\n");
            myPet.Name = Console.ReadLine();
            Console.WriteLine("Congratulations! You have a new pet named {0}!\n", myPet.Name);
            Menu();
            Console.ReadKey();
        }
    }
}
