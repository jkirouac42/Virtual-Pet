using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VPet
    {

        private string _name;
        public string Name
        { 
            get
            {
                return _name; 
            }
            set
            {
                _name = value;
            }

        }
        private int _hunger;
        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                _hunger = value;
            }
        }
        private int _thirst;
        public int Thirst
        {
            get
            {
                return _thirst;
            }
            set
            {
                _thirst = value;                
            }
        }
        private int _boredom;
        public int Boredom
        {
            get
            {
                return _boredom;
            }
            set
            {
                _boredom = value;               
            }
        }
        
       
        // 100 is bad; refactor accordingly
        // make a status point on menu
        
        public void Feed()
        {
            
            Console.WriteLine( Name + " is hungry\n");
            Console.WriteLine("How much do you want to feed your pet; 1 or 2 scooby snacks.\n");
            int scooby = int.Parse(Console.ReadLine());
            if (scooby == 1)
            {
                _hunger = _hunger - 10;
                _thirst = -_thirst + 10;
                Console.WriteLine("That was Scoobylicious! However now {0} is mad thirsty!\n", Name);

            }
             if (scooby == 2)
            {
                _hunger = _hunger - 20;
                Console.WriteLine("That was Scoobylicious! However now {0} is mad thirsty!\n", Name);
            }
            if (_hunger < 50)
            {
                Console.WriteLine("{0} has died. Maybe you should rethink Virtual Pet ownership.", Name);
            }



        }
        public void Drink()
        {
           
            Console.WriteLine(Name + " has a powerful thirst on.");
            Console.WriteLine("How many pints 1 or 2");
            int drank = int.Parse(Console.ReadLine());
            if (drank == 1)
            {
                _thirst = _thirst - 10;
                Console.WriteLine("That was great! Now {0} has a lot of energy. Must be playtime", Name);

            }
            if (drank == 2)
            {
                _thirst = _thirst - 20;
                Console.WriteLine("That was great! Now {0} has a lot of energy. Must be playtime", Name);
            }
            if (_thirst == 50)
            {
                Console.WriteLine("{0} has died. Maybe you should rethink Virtual Pet ownership.", Name);
            }
        }
        public void Play()
        {

            
            Console.WriteLine(Name + "wants to play!");
            Console.WriteLine("How rounds of mini golf will you play 1 or 2");
            int _play = int.Parse(Console.ReadLine());
            if (_play == 1)
            {
                _boredom = _boredom - 10;
                _hunger = _hunger + 15;
                _thirst = _thirst + 20;
                Console.WriteLine("That was great! However {0} is now sleepy.", Name, _boredom);

            }
            if (_play == 2)
            {
                _boredom = 100 - 20;
                _hunger = _hunger + 25;
                _thirst = _thirst + 30;
                Console.WriteLine("That was great! However {0} is now sleepy.", Name, _boredom);
            }
            if (_boredom == 25)
            {
                Console.WriteLine("{0} has left you for someone more fun. Maybe you should rethink Virtual Pet ownership.", Name);
            }
        }
        public void Tick()
        {
            Random random = new Random();

            int num = random.Next(1, 10);

            if (num <= 4)
            {
                _hunger = _hunger + 25;
                _thirst = _thirst + 15;
                _boredom = _boredom + 10;

                Console.WriteLine("What a good rest. May sure your pet has enought to eat and drink.\n Be sure to have some fun too!");
                
            }
             if (num >= 5 && num <= 9)
            {
                _hunger = _hunger + 2;
                _thirst = _thirst + 9;
                _boredom = _boredom + 30;

                Console.WriteLine("What a good rest. May sure your pet has enought to eat and drink.\n Be sure to have some fun too!");
            }

            else if (num == 10)
            {
                _hunger = 100;
                _thirst = 100;
                _boredom = 100;
            }

        }
        public void Status()
        {
            Console.WriteLine("Hunger = {0}\n\nThirst = {1}\n\nBoredom = {2}", _hunger, _thirst, _boredom);
        }
        
                
    }

    
}
