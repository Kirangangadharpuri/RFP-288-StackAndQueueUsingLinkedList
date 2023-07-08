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
                node.next=null;    //making address of next node nuul in first node
            }
            else
            {
                node.next = top;    //push top node to next node and top will having nw data
            }
            top = node;
            Console.WriteLine("Elements in stack : "+data);
           
        }
        public void Peek()
        {
            if(top==null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top value is : "+top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top value is : " + top.data);
            top = top.next;
            Console.WriteLine("Top value has been deleted successfully.");
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
