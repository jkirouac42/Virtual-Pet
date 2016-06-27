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


                Console.WriteLine("Select 1 to FEED your pet.");
                Console.WriteLine("Select 2 to quench you pets Thirst.");
                Console.WriteLine("Select 3 to PLAY with your pet.");
                Console.WriteLine("Select 4 to check your pets STATUS.");
                Console.WriteLine("Select 5 to take a chance if your pets stats are OUT OF CONTROL.\n");

                int choice = int.Parse(Console.ReadLine());

                myPet.Tick();

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
                
            }
        }
        static VPet myPet = new VPet();
        
        static void Main(string[] args)
        {

            Console.WriteLine("     Welcome to Virtual Pet\n");
            
          
            Console.WriteLine("Enter in a name for your new pet!\n");
            myPet.Name = Console.ReadLine();
            Console.WriteLine("\n      Congratulations! You have a new pet named {0}!\n", myPet.Name);
            Console.WriteLine("                           @..@   ");
            Console.WriteLine("                          (----)  ");
            Console.WriteLine("                         (>____<) ");
            Console.WriteLine("                         ^^ ~~ ^^   \n");

            Console.WriteLine("        Select a number 1-5 to raise your Virtual Pet.\n");
            Console.WriteLine("     \nBE SURE TO KEEP YOUR VIRTUAL PETS HUNGER, THIRST, AND BOREDOM LOW! ");

            myPet.Status();
            Menu();
            
            Console.ReadKey();
        }
    }
}


