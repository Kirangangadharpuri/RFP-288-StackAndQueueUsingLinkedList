using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class QueueDemo
    {
        Node head = null;
        public void Enque(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null) 
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data);
        }
        //public void Deque()
        //{
        //    if(head==null)
        //    {
        //        Console.WriteLine("Queue is empty");
        //    }
        //    else
        //    {
        //        while(head!=null)
        //        {
        //            Console.WriteLine("{0}Top element is deleted successfully",head.data);
        //            head = head.next;

        //        }
                
        //    }
        //}
        public void Display()
        {
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
