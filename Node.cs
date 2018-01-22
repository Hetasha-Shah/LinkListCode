using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     public class Node
    {
        public int data { get; set; }
        public Node next { get; set; }

        /// <summary>
        /// Constructor for the class
        /// </summary>
        /// <param name="num">Key of the node.</param>
        public Node(int num)
        {
            data = num;
            next = null;
        }
    }
}
