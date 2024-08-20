using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Martin");
            Console.WriteLine(person);
            person.name = "Benny";
            Console.WriteLine(person);
            Console.ReadLine();
        }
    }
}
