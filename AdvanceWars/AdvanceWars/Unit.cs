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

        bool CanMove(int row, int col, IMapObject currentTile)
        {
            
            throw new NotImplementedException();
            return false;
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
    }
}
