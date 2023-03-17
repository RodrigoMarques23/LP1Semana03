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
            Console.WriteLine("Numero de jogadores?");
            int n = Int32.Parse(Console.ReadLine());

            if (((myPowers & PlayerPowers.Fly) == PlayerPowers.Fly) && ((myPowers & PlayerPowers.SuperStrenght) == PlayerPowers.SuperStrenght))
            {
                Console.WriteLine("Flying Radiation!");
            }
        }
    }
}
