using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class LinkList
    {
        Node head;
        int count = 0;
       
        /// <summary>
        /// Inserting a node at the front of the link ist
        /// </summary>
        /// <param name="data">Data of the node to be pushed</param>
        public void pushAtFront(int data)
        {
            if (count == 0)
            {
                head = new Node(data);
                count++;
            }
            else
            {
                Node newNode = new Node(data);
                newNode.next = head.next;
                head.next = newNode;
                
            }
        }

        /// <summary>
        /// Pushing the node after a given node.
        /// </summary>
        /// <param name="pushAt">The node after which the new node to be pushed.</param>
        /// <param name="data">Data of the node to be pushed.</param>
        public void pushAtAGivenNode(int pushAt,int data)
        {
            Node n = head;
            while (n != null)
            {
                if (n.data == pushAt)
                {
                    Node newNode = new Node(data);
                    newNode.next = n.next;
                    n.next = newNode;
                }
                n = n.next;
            }

        }

        /// <summary>
        /// Pushing the node at the end of the link list.
        /// </summary>
        /// <param name="data">Data of the node to be pushed.</param>
        public void pushAtBack(int data)
        {
            Node n = head;
            while (n != null)
            {
                if (n.next == null) break;
                n = n.next;
            }
            Node newNode = new Node(data);
            n.next = newNode;
        }

     /// <summary>
     /// Printing the link list
     /// </summary>
        public void printList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + " ");
                n = n.next;
            }
        }

        /// <summary>
        /// Deletion of a node from a link list
        /// </summary>
        /// <param name="data">data is the key of the node to be deleted.</param>
        public void DeleteNode(int data)
        {
            Node current = head;
            Node previous = null;
            if (current == null)
            {
                Console.WriteLine("There are no nodes to delete.");
            }
            while (current != null)
            {
                previous = current;
                current = current.next;
                if (current.data == data)
                {
                    break;
                }
            }
            previous.next = current.next;
        }

    }
}
