using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for input values
            Console.WriteLine("Give me a string");
            string s = Console.ReadLine();
            Console.WriteLine("Give me a char");
            char a = char.Parse(Console.ReadLine());

            //Running every char in string
            foreach (char c in s)
            {
                if (c != a)
                {
                    Console.Write(c);
                }
            }
        }
    }
}
