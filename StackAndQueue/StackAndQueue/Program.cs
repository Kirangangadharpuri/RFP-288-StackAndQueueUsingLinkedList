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
                Console.WriteLine("Choose above option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        StackDemo stackDemo = new StackDemo();
                        stackDemo.Push(70);
                        stackDemo.Push(30);
                        stackDemo.Push(56);
                        stackDemo.Display();
                        break;
                    default:
                        Console.WriteLine("Invalide option");
                        break;
                }
            }
        }
    }
}
