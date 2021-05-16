using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class Location : GameObject, IHaveInventory
    {
        Inventory _inventory = new Inventory();
        public Location(string[] ids, string name, string desc) : base(ids, name, desc)
        {

        }

        public GameObject Locate(string id)
        {
            return _inventory.Fetch(id);
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public override string FullDescription
        {
            get
            {
                return "You are at " + this.Name + "\n" + base.FullDescription + "\nYou can see: \n " + _inventory.ItemList;
            }
        }
    }
}
