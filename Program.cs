using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class Program
    {
        static void Main(string[] args)
        {
            LinkList l1 = new LinkList();
            l1.pushAtFront(9);
            l1.pushAtFront(10);
            l1.pushAtFront(5);
            l1.pushAtAGivenNode(5, 99);
            l1.pushAtBack(100);
            l1.printList();
            Console.WriteLine("-----------------");
            l1.DeleteNode(10);
            l1.printList();

            Console.ReadLine();
        }
       
    }
}
