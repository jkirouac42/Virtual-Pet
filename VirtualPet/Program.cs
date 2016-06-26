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
                Console.WriteLine("        Select a number 1-5 to raise your Virtual Pet.\n");
                Console.WriteLine("     \nBE SURE TO KEEP YOUR VIRTUAL PETS HUNGER, THIRST, AND BOREDOM LOW! ");

                Console.WriteLine("\n      To FEED your pet press 1     To Quench that THIRST Press 2    \n\n      To PLAY with your pet Press 3    To check your pet's STATUS press 4\n");
               
                Console.WriteLine("\n          OH NO MY PETS STATS ARE OUT OF CONTROL!!\n                TAKE A CHANCE AND PRESS 5!");

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
                
            }
        }
        static VPet myPet = new VPet();
        
        static void Main(string[] args)
        {

            Console.WriteLine("     Welcome to Virtual Pet\n");
            
           // VPet myPet = new VPet(); uneeded
            Console.WriteLine("Enter in a name for your new pet!\n");
            myPet.Name = Console.ReadLine();
            Console.WriteLine("\n      Congratulations! You have a new pet named {0}!\n", myPet.Name);
            Console.WriteLine("                           @..@   ");
            Console.WriteLine("                          (----)  ");
            Console.WriteLine("                         (>____<) ");
            Console.WriteLine("                         ^^ ~~ ^^   \n");
            
            myPet.Status();
            Menu();
            
            Console.ReadKey();
        }
    }
}


/*
Boredom is not showing up after 2 pints


*/