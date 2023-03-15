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
            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w': myPerks |= Perks.WaterBreathing; break;
                    case 'a': myPerks |= Perks.AutoHeal; break;
                    case 's': myPerks |= Perks.DoubleJump; break;
                    case 'd': myPerks |= Perks.Stealth; break;
                    default: Console.WriteLine("Unkown Perk"); return;
                }
            }
            Console.WriteLine($"Player perks: {myPerks}");

            if (args.Length == 0)//In case there is no input
            {
                Console.WriteLine("No perks at all!");
            }

            if ((myPerks & Perks.Stealth & Perks.DoubleJump) = Perks.Stealth | Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }

            if ((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}
