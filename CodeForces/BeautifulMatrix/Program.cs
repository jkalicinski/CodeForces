using System;

namespace BeautifulMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int curPosY;
            int pos1Y = 0;
            int pos1X = 0;

            for (int i = 0; i < 5; i++)
            {
                if (pos1X > 0)
                    break;

                string line = Console.ReadLine();
                curPosY = 0;

                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == '0' || line[j] == '1')
                    {
                        if (line[j] == '1')
                        {
                            pos1Y = curPosY;
                            pos1X = i;
                            break;
                        }

                        curPosY++;
                    }
                }
            }

            int diffx = 2 - pos1X;
            int diffy = 2 - pos1Y;

            if (diffx < 0)
                diffx = diffx * (-1);

            if (diffy < 0)
                diffy = diffy * (-1);

            Console.WriteLine(diffx + diffy);
        }
    }
}
