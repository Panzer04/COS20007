using System;

namespace PassTask3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            for(int i = 0; i < 86450; i++)
            {
                clock.Tick();
                Console.WriteLine(clock.Time());
            }
        }
    }
}
