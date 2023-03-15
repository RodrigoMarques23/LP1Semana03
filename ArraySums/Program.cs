using System;

namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            float SomaLinha = 0;
            float SomaColuna = 0;

            //Asking input
            Console.WriteLine("Horizontal value?");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Vertical value?");
            int b = Int32.Parse(Console.ReadLine());

            float[,] array = new float[a, b];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Inserir i{i} e j{j}");
                    float f = float.Parse(Console.ReadLine());
                    array[i, j] = f;
                }
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    SomaColuna += array[i, j];
                }
                Console.WriteLine($"Soma da Coluna {j} = {SomaColuna}");
                SomaColuna = 0;
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    SomaLinha += array[i, j];
                }
                Console.WriteLine($"Soma da Linha {i} = {SomaLinha}");
                SomaLinha = 0;
            }
        }
    }
}
