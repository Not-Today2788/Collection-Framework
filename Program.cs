using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> saurabh = new Queue<string>();

            saurabh.Enqueue("Vinu");
            saurabh.Enqueue("Prakhar");
            saurabh.Enqueue("Shouvik");
            saurabh.Enqueue("Das");

            foreach(string s in saurabh)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("\n"+saurabh.Dequeue()+"\n");

            foreach (string s in saurabh)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n" + saurabh.Peek());


        }
    }
}
