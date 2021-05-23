using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace AdvanceWars
{
    class Tank : Unit, IDraw
    {
        public Tank(int health, int moves, int attack, Tile location) : base(health, moves, attack, location)
        {

        }

        public override void Draw(Point2D location)
        {
            SplashKit.LoadBitmap("Tank", "C:\\Users\\Jordan\\Documents\\GitHub\\COS20007\\AdvanceWars\\AdvanceWars\\tank16.bmp");
            bool test = SplashKit.HasBitmap("Tank");
            SplashKit.DrawBitmap("Tank", location.X, location.Y);
        }
    }
}
