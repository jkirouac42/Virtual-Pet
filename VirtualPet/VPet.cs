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
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get;set;}
        
        
    }

    
}
