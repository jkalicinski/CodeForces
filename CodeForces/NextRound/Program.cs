using System;
using System.Linq;

namespace NextRound
{
    class Program
    {
        static void Main(string[] args)
        {
            string nk = Console.ReadLine();
            string scores = Console.ReadLine();

            byte[] nkarray = nk.Split(' ').Select(n => Convert.ToByte(n)).ToArray();
            byte[] scoresarr = scores.Split(' ').Select(n => Convert.ToByte(n)).ToArray();

            int counter = 0;

            for (int i = 0; i < nkarray[0]; i++)
            {
                if (scoresarr[i] > 0 && scoresarr[i] >= scoresarr[nkarray[1] - 1])
                    counter++;
                else
                    break;
            }

            Console.WriteLine(counter);
        }
    }
}
