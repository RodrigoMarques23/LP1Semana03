using System;

namespace PlayerPerks
{
    class Program
    {
        /// <summary>
        /// Declarate Enum
        /// </summary>
        [Flags]
        enum Perks
        {
            WaterBreathing = 1,
            Stealth = 2,
            AutoHeal = 4,
            DoubleJump = 8
        };
        static void Main(string[] args)
        {
            Perks myPerks;
            myPerks = 0;
            int w = 0;
            int a = 0;
            int d = 0;
            int s = 0;

            foreach (char c in args[0])
                switch (c)
                {
                    case 'w':
                        w++;

                        break;

                    case 'a':
                        a++;

                        break;

                    case 's':
                        d++;

                        break;

                    case 'd':
                        s++;

                        break;

                    default:
                        Console.WriteLine("Unkown Perk");

                        return;
                }

            if (w % 2 == 1) myPerks |= Perks.WaterBreathing;
            if (a % 2 == 1) myPerks |= Perks.AutoHeal;
            if (d % 2 == 1) myPerks |= Perks.DoubleJump;
            if (s % 2 == 1) myPerks |= Perks.Stealth;

            Console.WriteLine($"Player perks: {myPerks}");

            if (args.Length == 0)//In case there is no input
            {
                Console.WriteLine("No perks at all!");
            }

            if (((myPerks & Perks.Stealth) == Perks.Stealth) && ((myPerks & Perks.DoubleJump) == Perks.DoubleJump))
            {
                Console.WriteLine("Silent Jumper!");
            }

            if ((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
