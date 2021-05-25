using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;
namespace AdvanceWars
{
    class Tank : Unit
    {
        public Tank(int health, int moves, int attack) : base(health, moves, attack)
        {

        }

        public override void Draw(int row, int col, int size)
        {
            SplashKit.LoadBitmap("Tank", "C:\\Users\\Jordan\\Documents\\GitHub\\COS20007\\AdvanceWars\\AdvanceWars\\textures\\tank16.bmp");
            bool test = SplashKit.HasBitmap("Tank");
            SplashKit.DrawBitmap("Tank", row * size, col * size);
        }


    }
}
