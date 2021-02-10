using System;

namespace BoyOrGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "CHAT WITH HER!";

            if (DistinctCount(input) % 2 != 0)
            {
                result = "IGNORE HIM!";
            }

            Console.WriteLine(result);
        }

        private static int DistinctCount(string input)
        {
            int distinct = 0;
            char[] array = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == input[i])
                    {
                        break;
                    }

                    if (array[j] == char.MinValue)
                    {
                        array[j] = input[i];
                        distinct++;
                        break;
                    }    
                }
            }

            return distinct;
        }
    }
}
