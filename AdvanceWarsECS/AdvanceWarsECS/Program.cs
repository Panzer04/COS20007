using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace AdvanceWarsECS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Window("Test", 800, 600);
            SDraw.Load();

            Entity tank = new Tank();
            List<Entity> entityList = new List<Entity>();

            entityList.Add(tank);

            while (true)
            {
                foreach(Entity e in entityList)
                {
                    SDraw.Draw((CDrawable)tank.Component);
                }
                
                SplashKit.RefreshScreen(1);
            }

        }
    }
}
