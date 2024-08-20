using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            list.Add(28);
            list.Add(73);
            list.Add(95);
            list.Add(4);
            list.Add(64);
            list.Add(32);
            list.Add(4);
            list.PrintNumbers();
            Console.ReadLine();
        }
    }
}
