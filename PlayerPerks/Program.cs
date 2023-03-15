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
            WaterBreathing,
            Stealth,
            AutoHeal,
            DoubleJump
        };
        static void Main(string[] args)
        {
            Perks myPerks;
            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'w': myPerks = Perks.WaterBreathing; break;
                    case 'a': myPerks = Perks.AutoHeal; break;
                    case 's': myPerks = Perks.DoubleJump; break;
                    case 'd': myPerks = Perks.Stealth; break;
                    default: Console.WriteLine(""); return;
                }
            }
            Console.WriteLine($"Player perks: {myPerks}");

            /*if (args.Length == 0)//In case there is no input
            {
                Console.WriteLine("Player has no perks");
            }

            if (myPerks == Perks.Stealth | Perks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }
            if (myPerks != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }*/
        }
    }
}
