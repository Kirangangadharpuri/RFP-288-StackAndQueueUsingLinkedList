using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1-Push data in stack");
                Console.WriteLine("2- Peek and Pop of stack");
                Console.WriteLine("3-Enque data in Queue");
                Console.WriteLine("Choose above option");
                int option = Convert.ToInt32(Console.ReadLine());
                StackDemo stackDemo = new StackDemo();
                QueueDemo queueDemo = new QueueDemo();
                switch (option)
                {
                    case 1:
                        stackDemo.Push(70);
                        stackDemo.Push(30);
                        stackDemo.Push(56);
                        stackDemo.Display();
                        break;
                        case 2:
                        stackDemo.Push(70);
                        stackDemo.Push(30);
                        stackDemo.Push(56);
                        stackDemo.Display();
                        Console.WriteLine("#############");
                        stackDemo.Peek();
                        Console.WriteLine("#############");
                        stackDemo.Pop();
                        Console.WriteLine("#############");
                        stackDemo.Display();
                        break;
                    case 3:
                        queueDemo.Enque(56);
                        queueDemo.Enque(30);
                        queueDemo.Enque(70);
                        //queueDemo.Display();
                        break;

                    default:
                        Console.WriteLine("Invalide option");
                        break;
                }
            }
        }
    }
}
