using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SplashKitSDK;

namespace AdvanceWarsECS
{
    static class SDraw
    {
        //Load textures into splashkit
        public static void Load()
        {
            SplashKit.LoadBitmap("tank", "C:\\Users\\Jordan\\Documents\\GitHub\\COS20007\\AdvanceWarsECS\\AdvanceWarsECS\\textures\\tank16.bmp");
        }

        public static void Draw(CDrawable draw)
        {            
            Color clr = Color.RandomRGB(0);
            SplashKit.DrawBitmap(draw.Texture, draw.X * draw.DrawSize, draw.Y * draw.DrawSize);
        }
    }
}
