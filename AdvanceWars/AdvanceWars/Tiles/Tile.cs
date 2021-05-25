using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    abstract class Tile : IMapObject
    {
        IMapObject[] _neighbours;
        private int _tileSize; 
        public Tile(int row, int col, int tileSize = 16)
        {
            Row = row;
            Col = col;
            _neighbours = new Tile[4];
            Unit = null;
            _tileSize = tileSize;
        }

        public bool Select(Point2D pt)
        {
            if(pt.X > Row*Size && pt.X < ((Row+1)* Size))
            {
                if(pt.Y > Col * Size && pt.Y < ((Col + 1) * Size))
                {
                    return true;
                }
            }
            return false;
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

        }
        public int Row { get; set; }
        public int Col { get; set; }

        public int Size
        {
            get
            {
                return _tileSize;
            }
            set
            {
                _tileSize = value;
            }
        }
        public Unit Unit { get; set; }
        public int MoveCost{ get; init; }

        public bool Selected { get; set; }
    }
}
