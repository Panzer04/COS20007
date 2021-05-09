using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passtask2._3
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);

        public string Name
        {
            get;            
        }
    }
}
