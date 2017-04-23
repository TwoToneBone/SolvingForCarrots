using System;

namespace SolvingForCarrots
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int lines = int.Parse(input[0]);
            for (int i = 0; i < lines; i++)
            {
                Console.ReadLine();
            }
            Console.WriteLine(input[1]);
        }
    }
}
