using System;

namespace BitPlusPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lines = Convert.ToByte(Console.ReadLine());
            int value = 0;

            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();

                if (line[0] == '+' || line[2] == '+')
                    value++;
                else
                    value--;
            }

            Console.WriteLine(value);
        }
    }
}
