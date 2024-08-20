using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public interface IAnimal
    {
        bool IsDog();
    }

    public class Animal : IAnimal
    {
        public string Species;
        public Animal(string species)
        {
            this.Species = species;
        }

            public bool IsDog()
        {
            if (this.Species == "Dog")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "This animal is " + Species;
        }
    }
}
