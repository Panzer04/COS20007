using System;

namespace MidSemTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Library _library = new Library("The point?");
            Game _eu4 = new Game("Europa Universalis IV", "Paradox Interactive", "PG13");
            Game _battlefield = new Game("Battlefield", "DICE", "MA15");
            Book _harryPotter = new Book("Harry Potter", "J.K Rowling", "9780747532743");
            Book _refactoring = new Book("Refactoring", "Martin Fowler", "0201485672");

            //Have to loan things out before adding to the library given the requirement
            /*The above is actually wrong, as objects are passed by reference - if we have the reference
             * then we can modify the object later, without going through the accessors for the library.
             * */
            _eu4.OnLoan = true;
            _harryPotter.OnLoan = true;

            _library.AddResource(_eu4);
            _library.AddResource(_battlefield);
            _library.AddResource(_harryPotter);
            _library.AddResource(_refactoring);

            Console.WriteLine("EU4 is on loan. Should return false.");
            Console.WriteLine(_library.HasResource("Europa Universalis IV"));
            Console.WriteLine("Refactoring is not on loan. Should return true");
            Console.WriteLine(_library.HasResource("Refactoring"));
            Console.WriteLine("Doesn't exist: Epic");
            Console.WriteLine(_library.HasResource("Epic"));

            Console.WriteLine("The danger of pass by reference: EU4 no longer on loan?");
            _eu4.OnLoan = false;
            Console.WriteLine(_library.HasResource("Europa Universalis IV"));
           
        }
    }
}
