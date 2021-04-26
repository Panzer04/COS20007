using System;

namespace MidSemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library _library = new Library("The point?");
            Game _eu4 = new Game("Europa Universalis IV", "Paradox Interactive", "PG13");
            Game _battlefield = new Game("Battlefield", "DICE", "MA15");
            Book _harryPotter = new Book("Harry Potter", "J.K Rowling", "9780747532743");
            Book _refactoring = new Book("Refactoring", "Martin Fowler", "0201485672");

            _eu4.OnLoan = true;
            _harryPotter.OnLoan = true;

            _library.AddResource(_eu4);
            _library.AddResource(_battlefield);
            _library.AddResource(_harryPotter);
            _library.AddResource(_refactoring);

            Console.WriteLine(_library.HasResource("Europa Universalis IV"));
            Console.WriteLine(_library.HasResource("Refactoring"));
            Console.WriteLine(_library.HasResource("Epic"));
        }
    }
}
