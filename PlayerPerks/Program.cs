using System;

namespace PlayerPerks
{
    class Program
    {
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
            if (args.Length == 0)
            {
                Console.WriteLine("Player has no perks");
            }
        }
    }
}
