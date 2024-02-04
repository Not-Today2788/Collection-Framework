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
            List<string> listna = new List<string>();

            listna.Add("A");
            listna.Add("B");
            listna.Add("C");
            listna.Add("D");
            listna.Add("E");

            //Console.WriteLine(listna);
            foreach (var i in listna)
            {
                Console.Write("     "+i);
            }


            Console.WriteLine();
            Console.WriteLine("\nRemoving B from the list\n");
            listna.Remove("B");

            foreach (var i in listna)
            {
                Console.Write("     " + i);
            }

            Console.WriteLine("\nRemoving elements in the range 0 to 3\n");
            listna.RemoveRange(0,3);

            foreach (var i in listna)
            {
                Console.Write("     " + i);
            }

            listna.Add("b");
            listna.Add("c");
            listna.Add("d");
            listna.Add("e");
            listna.Add("X");
            Console.WriteLine("\n");
            foreach (var i in listna)
            {
                Console.Write("     " + i);
            }

            Console.WriteLine("\n Elememt at 0th positon: "+ listna[0] + "\n");

            Console.WriteLine("Index of X: " + listna.IndexOf("X"));

            Console.WriteLine("\nList Count: "+ listna.Count+"\n");
            

            foreach(object i in listna)
            {
                Console.Write("     " + i);
            }
            Console.WriteLine();
        }
    }
}
