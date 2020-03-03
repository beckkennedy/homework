using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennedy_Assignment4
{

    class Person
    {
        public enum TypeEnum { InState, OutOfState }

        public string Name { get; set; }
        public string Address { get; set; }
        public TypeEnum Type { get; set; }

        
    }


}
