using System;
using System.Collections;
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
            Dictionary<int, string> ox = new Dictionary<int,string>();

            ox.Add(1, "one");
            ox.Add(2, "two");
            ox.Add(3, "three");
            ox.Add(4, "four");
            ox.Add(5, "five");

            //bool addedSuccessfully = ox.TryAdd(key, value);


            //Console.WriteLine(ox.TryAdd(6,"six"));

            ox.Remove(3);

            Console.WriteLine("\n1: "+ox[1]);

            Console.WriteLine(ox.TryGetValue(5,out string six ));

            Console.WriteLine(ox.ContainsKey(6 ));

            Console.WriteLine(ox.ContainsValue("four"));

            Console.WriteLine(six);

            foreach(var i in ox)
            {
                Console.WriteLine($"\nKey: {i.Key}  Value: {i.Value}");
            }
        }
    }
}
