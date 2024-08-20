using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1
{
    internal class Person
    {
        public string name;
        public Person(string name) { 
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
