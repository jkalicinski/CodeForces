using System;

namespace StonesOnTheTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string stones = Console.ReadLine();

            char prev = stones[0];
            int moves = 0;

            for (int i = 1; i < count; i++)
            {
                if (prev == stones[i])
                {
                    moves++;
                }
                else
                {
                    prev = stones[i];
                }
            }

            Console.WriteLine(moves);
        }
    }
}
