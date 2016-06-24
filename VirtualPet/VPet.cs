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
        private string petName;
        public string Name
        {
            get
            {
                return petName;
            }
            set
            {
                petName = value;
            }
        }
                       
        public int Hunger { get; set; }
        public int Thirst { get; set; }
        public int Boredom { get;set;}
    }

    
}
