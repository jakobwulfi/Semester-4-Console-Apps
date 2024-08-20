using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_1_6
{
    internal class MyList
    {
        public List<int> list = new List<int>();
        public MyList() {}

        public void Add(int number)
        {
            list.Add(number);
        }
        public void PrintNumbers()
        {
            int nmbr = 1;
            foreach (int number in list)
            {
                Console.WriteLine("Tal nr " + nmbr + " i listen er " + number + ". :D");
                nmbr++;
            }
        }
    }
}
