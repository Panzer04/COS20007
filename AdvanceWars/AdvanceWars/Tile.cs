using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    abstract class Tile : IMapObject, IDraw
    {
        IMapObject[] _neighbours;
        protected int _x;
        protected int _y;
        protected int _moveCost;
        protected int tileSize = 16;

        public Tile(int x, int y)
        {
            _x = x;
            _y = y;
            _neighbours = new Tile[4];
            _moveCost = 1;
        }

        public IMapObject Up
        {
            get
            {
                return _neighbours[0];
            }
            set
            {
                _neighbours[0] = value;
            }
        }
        public IMapObject Right
        {
            get
            {
                return _neighbours[1];
            }
            set
            {
                _neighbours[1] = value;
            }
        }
        public IMapObject Down
        {
            get
            {
                return _neighbours[2];
            }
            set
            {
                _neighbours[2] = value;
            }
        }
        public IMapObject Left
        {
            get
            {
                return _neighbours[3];
            }
            set
            {
                _neighbours[3] = value;
            }
        }

        public virtual void Draw()
        {
            //throw new NotImplementedException();
        }
        public int X
        {
            get { return _x; }
        }
        public int Y
        {
            get { return _y; }
        }
        public int MoveCost
        {
            get { return _moveCost; }
        }
    }
}
