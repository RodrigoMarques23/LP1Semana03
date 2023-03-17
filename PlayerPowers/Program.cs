using System;

namespace PlayerPowers
{
    class Program
    {
        [Flags]

        enum PlayerSuperPower
        {
            Fly = 1,
            XrayVision = 2,
            SuperStrength = 4

        };
        static void Main(string[] args)
        {

            Console.Write("Número de jogadores: ");

            int n = Convert.ToInt32(Console.ReadLine());

            PlayerSuperPower[] players = new PlayerSuperPower[n];

            for (int i = 0; i < players.Length; i++)
            {
                Console.Write($"Insira os poderes para o jogador {i + 1}: ");

                string powers = Console.ReadLine();

                foreach (char p in powers)
                    switch (p)
                    {
                        case 'f':
                            players[i] |= PlayerSuperPower.Fly;

                            break;

                        case 'x':
                            players[i] |= PlayerSuperPower.XrayVision;

                            break;

                        case 's':
                            players[i] |= PlayerSuperPower.SuperStrength;

                            break;
                    }
            }

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine($"Poderes do jogador {i + 1}: {players[i]}");

                if ((players[i] & PlayerSuperPower.Fly) ==
                    PlayerSuperPower.Fly &&
                    (players[i] & PlayerSuperPower.SuperStrength) ==
                    PlayerSuperPower.SuperStrength)
                    Console.WriteLine("Flying Radiation");
            }
        }
    }
}

