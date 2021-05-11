using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class Player : GameObject, IHaveInventory
    {
        Inventory _inventory = new Inventory();
        Location _location;

        //Initialise with default location, so as not to break existing code
        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _location = new Location(new string[] { "nowhere" }, "nowhere", "The void");
        }

        //Constructor with location parameter
        public Player(string name, string desc, Location location) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _location = location;
        }

        //Find an object with this id associated with the player object.
        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            }
            else
            {
                return _location.Locate(id);
            }
        }

        //Return a description of the inventory + decorative text
        public override string FullDescription
        {
            get
            {
                return "You are " + this.Name + " " + base.FullDescription + "\n You are carrying: \n " + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Location Location
        {
            get
            {
                return _location;
            }
        }
    }
}
