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
                Console.WriteLine("\nTo feed your pet press 1         To Quench that thirst press 2\n");
              
                Console.WriteLine("\nTo play with your pet press 3    To check your pet's status press 4\n");
               
                Console.WriteLine("\nTo take your chances! 5\n");

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

            Console.WriteLine("Welcome to Virtual Pet\n");
            
           // VPet myPet = new VPet(); uneeded
            Console.WriteLine("Enter in a name for your new pet!\n");
            myPet.Name = Console.ReadLine();
            Console.WriteLine("\nCongratulations! You have a new pet named {0}!\n", myPet.Name);
            Console.WriteLine("                      @..@   ");
            Console.WriteLine("                     (----)  ");
            Console.WriteLine("                    (>____<) ");
            Console.WriteLine("                    ^^ ~~ ^^   \n");
            
            myPet.Status();
            Menu();
            
            Console.ReadKey();
        }
    }
}
