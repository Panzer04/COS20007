using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class Player : GameObject
    {
        Inventory _inventory = new Inventory();
        
        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {

        }

        //Find an object with this id associated with the player object.
        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);               
            }
        }

        //Return a description of the inventory + decorative text
        public override string FullDescription
        {
            get
            {
                return "You are carrying: " + _inventory.ItemList;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

    }
}
