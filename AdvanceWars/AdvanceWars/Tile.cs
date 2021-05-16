using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    abstract class Tile : IDraw
    {
        Tile[] _neighbours;
        protected int _x;
        protected int _y;
        protected int _moveCost;
        protected int tileSize = 16;
        public Unit _unit;

        public Tile(int x, int y)
        {
            _x = x;
            _y = y;
            _neighbours = new Tile[4];
            _moveCost = 1;
        }

        public Tile Up
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
        public Tile Right
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
        public Tile Down
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
        public Tile Left
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
            Point2D unitDraw = new Point2D();
            unitDraw.X = _x * 16;
            unitDraw.Y = _y * 16;
            if (_unit is null)
            {
                //Do nothing. No unit on this tile
            }
            else
            {
                _unit.Draw(unitDraw);
            }

        }

        public Unit Unit
        {
            get
            {
                return _unit;
            }
            set
            {
                _unit = value;
            }
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
