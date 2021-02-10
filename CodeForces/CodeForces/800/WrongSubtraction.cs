using System;
using System.Linq;

namespace CodeForces._800
{
    public static class WrongSubtraction
    {
        public static void Run()
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            for (int i = 1; i <= input[1]; i++)
            {
                if (input[0] % 10 == 0)
                {
                    input[0] = input[0] / 10;
                }
                else
                {
                    input[0] = input[0] - 1;
                }
            }

            Console.WriteLine(input[0]);
        }
    }
}
