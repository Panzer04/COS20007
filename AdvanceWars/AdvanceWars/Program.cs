using System;
using SplashKitSDK;

namespace AdvanceWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Window("Test", 800, 600);
            SplashKit.Delay(5000);
        }
    }
}
