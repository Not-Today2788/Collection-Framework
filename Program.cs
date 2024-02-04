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
            Stack<int> qwe = new Stack<int>();

            qwe.Push(1);
            qwe.Push(2);
            qwe.Push(3);
            qwe.Push(4);
            qwe.Push(5);
            qwe.Push(6);
            qwe.Push(7);
            qwe.Push(8);
            qwe.Push(9);
            qwe.Push(10);
            qwe.Push(11);
            qwe.Push(12);

            Console.WriteLine("Does it contain 4 inside it: "+qwe.Contains(4));

            Console.WriteLine("\n Total Elements: " + qwe.Count);

            Console.WriteLine("\n Popping: "+qwe.Pop());

            Console.WriteLine("\n Total Elements: "+qwe.Count);

            Console.WriteLine("\n Top Element: "+qwe.Peek());

            Console.WriteLine();
            foreach(int i in qwe)
            {
                Console.Write(" "+i);
            }

            
            Console.WriteLine();

            int[] ints = qwe.ToArray();

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }



            qwe.Clear();
            Console.WriteLine("\nElements are gone: ");
            foreach (int i in qwe)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
