using System;
using System.Linq;

namespace DominoPiling
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToByte(n)).ToArray();

            if (input[0] % 2 == 0)
            {
                Console.WriteLine((input[0] / 2) * input[1]);
            }
            else if (input[1] % 2 == 0)
            {
                Console.WriteLine((input[1] / 2) * input[0]);
            }
            else if (input[0] > 2)
            {
                Console.WriteLine(((input[0] / 2) * input[1] + input[1] / 2));
            }
            else if (input[1] > 2)
            {
                Console.WriteLine(((input[1] / 2) * input[0] + input[0] / 2));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
