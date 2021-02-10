using System;
using System.Linq;

namespace HelpfulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length > 1)
            {
                string[] lst = new string[3];

                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case '1':
                            lst[0] += input[i];
                            break;
                        case '2':
                            lst[1] += input[i];
                            break;
                        case '3':
                            lst[2] += input[i];
                            break;
                        default:
                            break;
                    }
                }

                if (!string.IsNullOrEmpty(lst[0]))
                {
                    lst[0] = string.Join('+', lst[0].ToCharArray());
                }

                if (!string.IsNullOrEmpty(lst[1]))
                {
                    lst[01] = string.Join('+', lst[1].ToCharArray());
                }

                if (!string.IsNullOrEmpty(lst[2]))
                {
                    lst[2] = string.Join('+', lst[2].ToCharArray());
                }



                Console.WriteLine(string.Join('+', lst.Where(x => !string.IsNullOrEmpty(x))));
            }
            else
            {
                Console.WriteLine(input[0]);
            }
        }
    }
}