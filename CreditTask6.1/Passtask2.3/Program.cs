using System;

namespace Passtask2._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            LookCommand _look = new LookCommand();

            Console.WriteLine("Please enter your player's name: ");
            string _name = Console.ReadLine();
            Console.WriteLine("Please enter your player description: ");
            string _desc = Console.ReadLine();

            //Set up location
            Location _location = new Location(new string[] { "Swinburne" }, "Swinburne Univeristy", "A place of learning");
            //Add Item to location
            Item _sword = new Item(new string[] { "sword" }, "Sword", "A rusted, yet sharp sword");
            _location.Inventory.Put(_sword);
            Player _player = new Player(_name, _desc, _location);

            Item _apple = new Item(new string[] { "apple" }, "Apple", "A delicious red apple");

            Bag _backpack = new Bag(new string[] { "backpack" }, "Backpack", "A sturdy hiking bag");
            Item _book = new Item(new string[] { "book" }, "Book", "A nebulous book");

            _player.Inventory.Put(_apple);
            _player.Inventory.Put(_book);
            _player.Inventory.Put(_backpack);
            ((Bag)_player.Inventory.Fetch("backpack")).Inventory.Put(_book);

            Console.WriteLine(_player.Location.FullDescription);

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");
                Console.WriteLine(_look.Execute(_player, command));
            }
        }
    }
}
