using System;
using System.Collections.Generic;
using System.Text;

namespace SingleLinkedListProject
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            Node p;
            int n = 0;
            p = start;
            while(p!=null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of nodes in the list = " + n);
        }

        public bool Search(int x)
        {
            int position = 1;
            Node p = start;
            while(p!=null)
            {
                if (p.info == x)
                    break;
                position++;
                p = p.link;
            }
            if(p==null)
            {
                Console.WriteLine(x + " not found in list");
                return false;
            }

            else
            {
                Console.WriteLine(x + " is at position " + position);
                return true;
            }
        }

        public void InsertInTheBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }

        public void InsertAtTheEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if(start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while(p != null)
            {
                p = p.link;
            }
            p.link = temp;
        }

        public void CreateList()
        {
            int i, n, data;

            Console.Write("Enter the number of nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;
            for(i=1;i<=n;i++)
            {
                Console.Write("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtTheEnd(data);
            }
        }

        public void insertAfter(int data, int x)
        {
            Node p = start;
            while(p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
            else
            {
                Node temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void insertBefore(int data, int x)
        {
            Node temp;

            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if(x == start.info)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
                Console.WriteLine(x + " not present in the list");
            else;
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        } 

        public void InsertAtPosition(int data, int k)
        {
            Node temp;
            int i;

            if(k==1)
            {
                temp = new Node(data);
                temp.link = start;
                start = temp;
                return;
            }

            Node p = start;
            for (i = 1; i < k - 1 && p != null; i++)
                p = p.link;

            if (p == null)
                Console.WriteLine("You can insert only upto " + i + "th position");
            else
            {
                temp = new Node(data);
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            if (start == null)
                return;

            if(start.link == null)
            {
                start = null;
                return;
            }

            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteNode(int x)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty\n");
                return;
            }

            if(start.info == x)
            {
                start = start.link;
                return;
            }

            Node p = start;
            while(p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }

            if (p.link == null)
                Console.WriteLine("Element " + x + "not in list");
            else
                p.link = p.link.link;
        }

        public void ReverseList()
        {
            Node prev, p, next;
            prev = null;
            p = start;
            while(p!=null)
            {
                next = p.link;
                p.link = prev;
                prev = p;
                p = next;
            }
            start = prev;
        }

        public void Concatenate()
        {

        }


    }
}
