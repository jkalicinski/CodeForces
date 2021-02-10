using System;
using System.Linq;

namespace BearAndBigBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int years = 0;

            while (input[0] <= input[1])
            {
                years++;
                input[0] = input[0] * 3;
                input[1] = input[1] * 2;
            }

            Console.WriteLine(years);
        }
    }
}
