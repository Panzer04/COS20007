using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    class Grassland : Tile, IDraw
    {
        public Grassland(int rows, int columns) : base(rows, columns)
        {
            SplashKit.LoadBitmap("Grassland", "C:\\Users\\Jordan\\Documents\\GitHub\\COS20007\\AdvanceWars\\AdvanceWars\\grassland.bmp");
        }

        public override void Draw()
        {
            bool test = SplashKit.HasBitmap("Grassland");
            Color clr = Color.RandomRGB(0);
            SplashKit.DrawBitmap("Grassland", base._x * base.tileSize, base._y * base.tileSize);
            base.Draw();
        }
    }
}
