using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class Inventory
    {
        List<Item> _items = new List<Item>();
        public Inventory() { }

        //Check if Inventory has Item
        public bool HasItem(string id)
        {
            foreach (Item itm in _items)
            {
                if (itm.AreYou(id))
                {
                    return true;
                }               
            }
            return false;
        }

        //Put item in Inventory
        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        //Return and remove item from inventory
        public Item Take(string id)
        {
            Item itm = Fetch(id);
            if(itm is not null)
            {
                _items.Remove(itm);                
                return itm;
            }
            return null;
        }

        //Return item without removing from Inventory
        public Item Fetch(string id)
        {
            foreach (Item itm in _items)
            {
                if (itm.AreYou(id))
                {
                    return itm;
                }                
            }
            return null;
        }

        public string ItemList
        {
            get
            {
                string itemList = "";
                foreach(Item itm in _items)
                {
                    itemList += "\t" + itm.ShortDescription + "\n";
                }
                return itemList;
            }
        }
    }
}
