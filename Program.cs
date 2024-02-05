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
            //Creating Linkedlist
            LinkedList<string> lnlst = new LinkedList<string>();

            //inserting elements
            //lnlst.AddLast("a");
            lnlst.AddFirst("a");
            lnlst.AddLast("b");
            lnlst.AddLast("c");
            lnlst.AddLast("d");
            lnlst.AddLast("e");

            LinkedListNode<string> node2 = lnlst.Find("c");
            
            if (node2 != null)
            {
                lnlst.AddBefore(node2, "cat");
                lnlst.AddAfter(node2, "dog");
            }
            else
            {
                Console.WriteLine("Node not found");
            }

            /* var node= lnlst.AddLast("b");
            lnlst.AddAfter(node, "c");
            lnlst.AddBefore(node, "d");
            */

            foreach(var item in lnlst)
            {

                Console.WriteLine(item);
            }
        }
    }
}
