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
        
        public Unit(int health, int moves, int attack)
        {
            Health = health;
            Moves = moves;
            AttackStrength = attack;
        }

        public virtual void Draw(int row, int col, int size)
        {
            
        }

        /// <summary>
        /// Use unit to attack other units; Units may implement different attack methods
        /// </summary>
        /// <param name="opponent">The opposing unit to damage/take damage from</param>
        public virtual Unit Attack(Unit opponent)
        {
            opponent.Health =- this.AttackStrength;
            if (opponent.Health <= 0)
            {
                //Unit dies
                return null;
            }
            else
            {
                //Take retaliation damage
                opponent.Attack(this);
                return opponent;                
            }
        }
        public int Health { get; set; }
        public int Moves { get; set; }
        public int AttackStrength { get; set; }

        
    }
}
