using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class StackDemo
    {
        public Node top;
        public StackDemo()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if(top == null)
            {
                node.next=null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("Elements in stack : "+data);
           
        }
        public void Display()
        {
            Node temp = top;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp=temp.next;
            }
        }
    }
}
