using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWars
{
    class Grassland : Tile
    {
        public Grassland(int rows, int columns, int tileSize = 16) : base(rows, columns, tileSize)
        {
            SplashKit.LoadBitmap("Grassland", "C:\\Users\\Jordan\\Documents\\GitHub\\COS20007\\AdvanceWars\\AdvanceWars\\textures\\grassland.bmp");
            base.MoveCost = 5;
        }

        public override void Draw()
        {
            base.Draw();
            bool test = SplashKit.HasBitmap("Grassland");
            Color clr = Color.RandomRGB(0);
            SplashKit.DrawBitmap("Grassland", base.Row * base.Size, base.Col * base.Size);            
            Unit?.Draw(base.Row, base.Col, base.Size);
        }
    }
}
