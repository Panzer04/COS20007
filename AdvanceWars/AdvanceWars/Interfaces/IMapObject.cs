using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWars
{
    public interface IMapObject
    {
        public IMapObject Up{ set; get; }
        public IMapObject Down { set; get; }
        public IMapObject Left { set; get; }
        public IMapObject Right { set; get; }


    }
}
