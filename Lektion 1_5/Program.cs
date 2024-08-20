using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal doggy = new Animal("Dog");
            Console.WriteLine(doggy.IsDog());
            Console.WriteLine(doggy);
            Console.ReadLine();
        }
    }
}
