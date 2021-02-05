using System;

namespace Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string answer = "NO";

            if (number > 3 && number <= 100 && number % 2 == 0)
            {
                answer = "YES";
            }

            Console.WriteLine(answer);
        }
    }
}
