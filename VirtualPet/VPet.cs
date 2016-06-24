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
        public string _name;
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
        public int _hunger;
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
        public int _thirst;
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
        public int _boredom;
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
        
        /*
        Hunger--feed makes it go up--tick makes it go down
        */
    }

    
}
