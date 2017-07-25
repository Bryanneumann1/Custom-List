using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListTest<int> List = new ListTest<int>();
            ListTest<int> List2 = new ListTest<int>();

            foreach(int i in List)
            {
                Console.WriteLine(i);
            }
        }
    }
}
