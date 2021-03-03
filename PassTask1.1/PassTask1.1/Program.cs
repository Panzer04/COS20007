using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassTask1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Message myMessage;
            myMessage = new Message("Hello, world!");

            Message[] messages = new Message[4];

            messages[0] = new Message("Why hello, newby");
            messages[1] = new Message("You're awesome!");
            messages[2] = new Message("Overrated...");
            messages[3] = new Message("Classic :)");

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            if(name == "Jordan")
            {
                messages[0].Print();
            }
            else if(name == "Kim")
            {
                messages[1].Print();
            }
            else if(name == "Keanu")
            {
                messages[2].Print();
            }
            else
            {
                messages[3].Print();
            }
            Console.ReadLine();

        }
    }
}
