using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class LinkedList
    {
        private Node head;

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
        
        public void InsertAt(int data,int pos)
        {
            if (pos < 0)
            {
                return;
            }
            Node newNode = new Node(data);
            if (pos == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            Node current = head;
            for(int i=1;i<pos && current != null; i++)
            {
                current = current.next;
            }
            if (current == null)
            {
                Console.WriteLine("Index was out of bound");
            }

            newNode.next = current.next;
            current.next = newNode;
        }

        public void DeleteNode(int pos)
        {
            if (pos < 1)
            {
                return;
            }

            Node current = head;
            for(int i = 0; i < pos-1 && current != null; i++)
            {
                current = current.next;
            }

            if (current.next == null)
            {
                Console.WriteLine("Index is out of bound");
                return;
            }
            current.next = current.next.next;
        }

        public void ReverseLinkedList()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node curr = head;
            Node prev = null;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + "->");
                current = current.next;
            }
            Console.WriteLine("null");
        }
    }
}
