using System;

namespace Clock
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Clock clock = new Clock();

            Console.WriteLine($"Initialize: {clock.GetTime()}");

            for (int i = 0; i < 86399; i++)
            {
                clock.Tick();
            }
            Console.WriteLine($"Time: {clock.GetTime()}");
        }
    }
}
