using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to your Virtual Pet Fun Console\n\n");
                Console.WriteLine("\nTo feed your pet press 1         To feed your pet press 1\n");
              
                Console.WriteLine("\nTo play with your pet press 3    To check your pet's status press 4\n");
               
                Console.WriteLine("\nTo get some shut eye press 5\n");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    myPet.Feed();
                    Menu();
                }

                if (choice == 2)
                {
                    myPet.Drink();
                    Menu();
                }

                if (choice == 3)
                {
                    myPet.Play();
                    Menu();
                }
                if (choice == 4)
                {
                    myPet.Status();
                    Menu();
                }
                if(choice == 5)
                {
                    myPet.Tick();
                }

                else break;
            }
        }
        static VPet myPet = new VPet();
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Virtual Pet\n");
            
           // VPet myPet = new VPet(); uneeded
            Console.WriteLine("Enter in a name for your new pet!\n");
            myPet.Name = Console.ReadLine();
            Console.WriteLine("\nCongratulations! You have a new pet named {0}!\n", myPet.Name);
            //Console.WriteLine("Press one to have fun with {0} your new Virtual Pet", myPet.Name);
            //int getmenu = int.Parse(Console.ReadLine());
            //if (getmenu == 1)
            //{
            //    return Menu();
            //}
            Menu();

            Console.ReadKey();
        }
    }
}
