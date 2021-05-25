using System;
using SplashKitSDK;

namespace AdvanceWars
{
    class Program
    {
        static void Main(string[] args)
        {
            new Window("Test", 800, 600);
            Map map = new Map(10, 10, 16);
            Tile newTile = new Grassland(5, 5);
            Tank tank = new Tank(10, 10, 10);
            map[5, 5] = newTile;
            newTile.Unit = tank;
            while (true)
            {
                SplashKit.ProcessEvents(); //Check user inputs - should only call once
                SplashKit.ClearScreen(); //Clear screen to white


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    map.Select((int)SplashKit.MousePosition().X, (int)SplashKit.MousePosition().Y);
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    map.Move((int)SplashKit.MousePosition().X, (int)SplashKit.MousePosition().Y);
                }

                map.Draw();
                SplashKit.RefreshScreen();                
            }



        }
    }
}
