using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceWars
{
    public interface IMapObject
    {
        //Map objects know their neighbours and their own location
        public IMapObject Up{ set; get; }
        public IMapObject Down { set; get; }
        public IMapObject Left { set; get; }
        public IMapObject Right { set; get; }

        //Default implementation; Not sure if this is a good idea or not, but the program is small
        public System.Collections.IEnumerable Neighbours
        {
            get
            {
                yield return Up;
                yield return Right;
                yield return Down;
                yield return Left;
            }
        }

        public int Row { get; set; }
        public int Col { get; set; }


    }
}
