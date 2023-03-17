using System;

namespace PlayerPowers
{
    class Program
    {
        [Flags]

        enum PlayerPowers
        {
            Fly = 1,
            XRayVision = 2,
            SuperStrenght = 4

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
