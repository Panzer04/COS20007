using System;
using SplashKitSDK;

namespace AdvanceWars
{
    class Program
    {
        static void Main(string[] args)
        {
            new Window("Test", 800, 600);
            while (true)
            {
                Map map = new Map(10, 10);
                Console.WriteLine("Hello World!");
                Console.WriteLine("TEST");

                Tile newTile = new Grassland(5, 5);
                Tank tank = new Tank(10, 10, 10, newTile);

                map[5, 5] = tank;
                map.Draw();
                SplashKit.RefreshScreen(1);
                
            }



        }
    }
}
