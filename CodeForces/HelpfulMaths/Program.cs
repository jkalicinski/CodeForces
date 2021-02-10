using System;

namespace HelpfulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers;

            if (input.Length > 1)
            {
                int arrayLength = input.Length - (((input.Length + 1) - (input.Length + 1) / 2) - 1);
                numbers = new int[arrayLength];
                int index = 0;

                for (int i = 0; i < input.Length; i = i + 2)
                {
                    numbers[index] = Convert.ToInt32(input[i]);
                    index++;
                }


            }
            else
            {
                Console.WriteLine(input[0]);
            }
        }
    }
}
