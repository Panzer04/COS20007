using System;
using SplashKitSDK;

namespace AdvanceWars
{
    class Program
    {
        static void Main(string[] args)
        {
            new Window("Test", 800, 600);
            Map map = new Map(10, 10);
            Tile newTile = new Grassland(5, 5);
            Tank tank = new Tank(10, 10, 10, newTile);
            map[5, 5] = tank;

            while (true)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("TEST");
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    

                }
                map.Draw();
                SplashKit.RefreshScreen(1);                
            }



        }
    }
}
