using System;

namespace WordCapitalization
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if ((byte)input[0] > 96)
            {
                Console.WriteLine($"{(char)((byte)input[0] - 32)}{input.Substring(1, input.Length - 1)}");
            }
            else
            {
                Console.WriteLine(input); 
            }
        }
    }
}
