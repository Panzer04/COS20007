using System;
using SplashKitSDK;

namespace AdvanceWarsECS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Window("Test",800, 600);


            Entity tank = new Tank();
            while (true)
            {
                SDraw.Draw((CDrawable)tank.Component);
                SplashKit.RefreshScreen(1);
            }
            
        }
    }
}
