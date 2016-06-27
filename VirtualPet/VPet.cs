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




        public void Feed()
        {

            Console.WriteLine(Name + " is hungry\n");
            Console.WriteLine("How much do you want to feed your pet: 1 or 2 packets of crisps.\n");
            int scooby = int.Parse(Console.ReadLine());
            if (scooby == 1)
            {
                _hunger = _hunger - 10;
                _thirst = _thirst + 5;
                _boredom = _boredom + 10;
                Console.WriteLine("That was brilliant! However now {0} is mad thirsty!\n", Name);

            }
            if (scooby == 2)
            {
                _hunger = _hunger - 25;
                _thirst = _thirst + 10;
                _boredom = _boredom + 15;
                Console.WriteLine("That was brilliant! However now {0} is mad thirsty!\n", Name);
            }

            Status();

        }
        public void Drink()
        {

            Console.WriteLine(Name + " has a powerful thirst on.");
            Console.WriteLine("How about a Pan Galactic Gargle Blaster? 1 or 2");
            int drank = int.Parse(Console.ReadLine());
            if (drank == 1)
            {
                _thirst = _thirst - 10;
                _boredom = _boredom + 15;
                Console.WriteLine("That was great! Now {0} has a lot of energy. Must be playtime", Name);

            }
            if (drank == 2)
            {
                _thirst = _thirst - 20;
                _boredom = _boredom + 25;
                Console.WriteLine("That was great! Now {0} has a lot of energy. Must be playtime", Name);
            }
            Status();
        }
        public void Play()
        {


            Console.WriteLine(Name + " wants to play!");
            Console.WriteLine("How many Vogon poems will you avoid 1 or 2");
            int _play = int.Parse(Console.ReadLine());
            if (_play == 1)
            {
                _boredom = _boredom - 10;
                _hunger = _hunger + 10;
                _thirst = _thirst + 15;
                Console.WriteLine("Thank goodness for infinate improbability drives!");
            }

            if (_play == 2)
            {
                _boredom = _boredom - 15;
                _hunger = _hunger + 20;
                _thirst = _thirst + 20;
                Console.WriteLine("Thank goodness for infinate improbability drives!");
            }

            Status();
            
        }
        public void Tick()
        {
            Random random = new Random();

            int num = random.Next(1, 10);

            if (num <= 4)
            {
                _hunger = _hunger + 5;
                _thirst = _thirst + 3;
                _boredom = _boredom + 10;
                Console.WriteLine("Don't Panic!\n\n");
                Status();

            }
            if (num >= 5 && num <= 8)
            {
                _hunger = _hunger + 15;
                _thirst = _thirst + 10;
                _boredom = _boredom + 5;
                Console.WriteLine("Must be Thursday... I never got the hang of Thursdays.");
                Status();
            }

             if (num >= 9)
            {
                _hunger = 100;
                _thirst = 100;
                _boredom = 100;
                Console.WriteLine("Vogon constructor fleet has arrived. Grab your towel and hitch a ride.", Name);
                Thanks();
            }
            
        }
        public void Status()
        {
            Console.WriteLine("\n        Status: Hunger = {0}   Thirst = {1}   Boredom = {2}\n", _hunger, _thirst, _boredom);

            if (_hunger >= 25 && _hunger < 49)
            {
                Console.WriteLine("DUDE FEED YOUR PET!");
            }
            if (_hunger >= 100)
            {
                Console.WriteLine("YOUR PET IS NOW VIRTUALLY DECEASED!");
                Thanks();
            }
            if (_thirst >= 25 && _hunger < 49)
            {
                Console.WriteLine("\nYOU MAY WANT TO BUY THAT PET A PINT!");
            }
            if (_thirst >= 100)
            {
                Console.WriteLine("\nPET IS NOW SHRIVELED LIKE A HOT DOG LEFT\nON THE COALS TOO LONG");
                Thanks();
            }
            if (_boredom >= 25 && _boredom < 49)
            {
                Console.WriteLine("IS THERE ANYTHING TO DO AROUND HERE? GAHHH SO BORED!\n");
            }
            if (_boredom >= 100)
            {
                Console.WriteLine("YOUR PET HAS LEFT YOU FOR SOMEONE MORE FUN!");
                Thanks();
            }

            if (_hunger < 0)
            {
                _hunger = 0;
            }

            if (_thirst < 0)
            {
                _thirst = 0;
            }

            if (_boredom < 0)
            {
                _boredom = 0;
            }
        }
        public void Thanks()
        {
            Console.WriteLine("So long and thanks for all the fish\n");
            Console.WriteLine("Time is an illusion...lunchtime doubly so ~ Ford Prefect.");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
    
}

    

