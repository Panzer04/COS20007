using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    abstract class Unit
    {
        protected int _health;
        protected int _moves;
        protected int _attack;
        public Unit(int health, int moves, int attack)
        {
            _health = health;
            _moves = moves;
            _attack = attack;
        }

        public virtual void Draw(Point2D location)
        {

        }

        bool CanMove(int row, int col, Tile currentTile)
        {
            if(currentTile.X == row && currentTile.Y == col)
            {
                return true;
            }
            throw new NotImplementedException();
            return false;
        }
    }
}
