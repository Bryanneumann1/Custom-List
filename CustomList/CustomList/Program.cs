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

            ListTest<string> List = new ListTest<string>() { };

            //List.Add(0);
            //List.Add(1);
            //List.Add(2);
            //List.Add(3);
            //List.Add(4);
            //List.Add(5);
            //List.Remove(2);
            //Console.WriteLine(List.Count);
            //Console.WriteLine(List[2]);

            //List.Add("tom");
            //List.Add("jim");
            //List.Add("jack");
            //List.Add("james");
            //List.Add("jerry");
            //List.Remove("tom");




            Console.ReadKey();



            ListTest<int> List2 = new ListTest<int>();

            foreach(int i in List)
            {
                Console.WriteLine(i);
            }
        }
    }
}
