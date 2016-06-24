using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VPet
    {

        /* class animal
             Hunger
             Thirst
             boredom
             tiredness*/
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
            _hunger = 10;
            Console.WriteLine( Name + "is hungry");
            Console.WriteLine("How much do you want to feed your pet?\n 1 or 2 scooby snacks.");
            int scooby = int.Parse(Console.ReadLine());
            if (scooby == 1)
            {
                _hunger = 100 - 10;
                Console.WriteLine("{0} is now at {1} hunger",Name, _hunger);
                
            }
            if (scooby == 2)
            {
                _hunger = 100 - 20;
            }
            
        }
        public void Drink()
        {
            _thirst = 100;
            Console.WriteLine(Name + " has a powerful thirst on.");
            Console.WriteLine("How many pints 1 or 2");
            int drank = int.Parse(Console.ReadLine());
            if (drank == 1)
            {
                _thirst = 100 - 10;
                Console.WriteLine("{0} is now at {1} thirst", Name, _thirst);

            }
            if (drank == 2)
            {
                _thirst = 100 - 20;
            }
        }
        public void Play()
        {
            
            _boredom = 100;
            Console.WriteLine(Name + "is bored");
            Console.WriteLine("How rounds of disc golf will you play 1 or 2");
            int _play = int.Parse(Console.ReadLine());
            if (_play == 1)
            {
                _boredom = 100 - 10;
                Console.WriteLine("{0} is now at {1} hunger", Name, _boredom);

            }
            if ( _play == 2)
            {
                _boredom = 100 - 20;
            }
        }
        
        /*
        Hunger--feed makes it go up--tick makes it go down
        */
    }

    
}
