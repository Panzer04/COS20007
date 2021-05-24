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
        private int _moveCost;
        protected int tileSize = 16;

        public Tile(int row, int col)
        {
            Row = row;
            Col = col;
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

        //Foreach iterator of neighbours
        public System.Collections.IEnumerable Neighbours;

        public abstract void Draw();
        public int Row { get; set; }
        public int Col { get; set; }

        public int MoveCost
        {
            get { return _moveCost; }
        }
    }
}
