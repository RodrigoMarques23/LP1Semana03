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
            PlayerPowers myPowers;
            myPowers = 0;

            Console.WriteLine("Numero de jogadores?");
            int n = Int32.Parse(Console.ReadLine());
            int[] players = new int[n];

            foreach (int a in n)
            {
                Console.WriteLine("Quais sao os teus poderes?");
                switch (c)
                {
                    case 'f':
                        myPowers |= PlayerPowers.Fly;
                        break;

                    case 'x':
                        myPowers |= PlayerPowers.XRayVision;
                        break;

                    case 's':
                        myPowers |= PlayerPowers.SuperStrenght;
                        break;

                    default:
                        Console.WriteLine("Unkown Power");

                        return;
                }
            }

            if (((myPowers & PlayerPowers.Fly) == PlayerPowers.Fly) && ((myPowers & PlayerPowers.SuperStrenght) == PlayerPowers.SuperStrenght))
            {
                Console.WriteLine("Flying Radiation!");
            }
        }
    }
}
