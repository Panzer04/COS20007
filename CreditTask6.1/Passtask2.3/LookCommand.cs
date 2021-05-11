using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {
        }

        public override string Execute(Player p, string[] text)
        {
            IHaveInventory container;
            string itemID;

            if ((text.Length != 3) && (text.Length != 5))
            {
                Console.WriteLine(text.Length);
                return "I don't know how to look like that";
            }

            //ToLower so that input is generic.
            if (text.First().ToLower() != "look")
            {
                return "Error in look input";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }
            }

            if (text.Length == 3)
            {
                container = p as IHaveInventory;
            }
            else //Can only be 5 from if check above
            {
                container = FetchContainer(p, text[4]);
            }
            if(container is null)
            {
                return $"I can't find the {text[4]}";
            }
            itemID = text[2];
            return LookAtIn(itemID, container);
        }

        private IHaveInventory FetchContainer(Player p, string containerID)
        {
            return p.Locate(containerID) as IHaveInventory;
        }

        private string LookAtIn(string thingID, IHaveInventory container)
        {
            if (container.Locate(thingID) is null)
            {
                return $"I can't find the {thingID}";
            }
            else
            {
                return container.Locate(thingID).FullDescription;
            }
        }
    }
}
