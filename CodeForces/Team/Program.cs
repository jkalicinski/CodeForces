using System;
using System.Linq;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int problems = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < problems; i++)
            {
                string solution = Console.ReadLine();

                if (solution.ToCharArray().Count(x => x == '1') > 1)
                    result++;
            }

            Console.WriteLine(result);
        }
    }
}
