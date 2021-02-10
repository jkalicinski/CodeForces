using System;
using System.Linq;

namespace SoldierAndBananas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int sum = 0;

            for (int i = 1; i <= input[2]; i++)
            {
                sum += i * input[0]; 
            }

            if (sum - input[1] >= 0)
            {
                Console.WriteLine(sum - input[1]);
            }
            else 
            {
                Console.WriteLine(0);
            }           
        }
    }
}
