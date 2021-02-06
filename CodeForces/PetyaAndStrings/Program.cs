using System;

namespace PetyaAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < first.Length; i++)
            {
                int charValF = (sbyte)first[i];
                int charValS = (sbyte)second[i];

                if (charValF >= 97)
                    charValF = charValF - 32;

                if (charValS >= 97)
                    charValS = charValS - 32;

                if (charValF > charValS)
                {
                    result = 1;
                    break;
                }
                else if (charValF < charValS)
                {
                    result = -1;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
