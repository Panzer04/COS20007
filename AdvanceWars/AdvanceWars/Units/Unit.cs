using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    abstract class Unit : IMapObject
    {
        protected int _health;
        protected int _moves;
        protected int _attack;
        protected Tile _location;
        public Unit(int health, int moves, int attack, Tile location)
        {
            _health = health;
            _moves = moves;
            _attack = attack;
            _location = location;
        }

        public virtual void Draw()
        {
            _location.Draw();
        }

        //Lowest cost of moving to a specified tile
        int moveCost(Tile otherTile, int moveSpent = 0, List<Tile> searched = null)
        {
            foreach(Tile t in _location.Neighbours)
            {
                if (t is null)
                {
                    return 1000;
                }
                if (t == otherTile)
                {
                    return moveSpent;
                }
                else
                {
                    searched.Add(_location);
                    return moveCost(otherTile, moveSpent + otherTile.MoveCost, searched);
                }

            }
            throw new NotImplementedException();
        }


        public Tile Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        public IMapObject Up
        {
            get
            {
                return _location.Up;
            }
            set
            {
                _location.Up = value;
            }
        }
        public IMapObject Right
        {
            get
            {
                return _location.Right;
            }
            set
            {
                _location.Right = value;
            }
        }
        public IMapObject Down
        {
            get
            {
                return _location.Down;
            }
            set
            {
                _location.Down = value;
            }
        }
        public IMapObject Left
        {
            get
            {
                return _location.Left;
            }
            set
            {
                _location.Left = value;
            }
        }

        public int Row
        {
            get
            {
                return _location.Row;
            }
            set
            {
                _location.Row = value;
            }
        }
        public int Col
        {
            get
            {
                return _location.Col;
            }
            set
            {
                _location.Col = value;
            }
        }
    }
}
