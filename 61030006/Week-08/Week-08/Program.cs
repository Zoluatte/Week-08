using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplyTable = new int[12, 12];
            for (int row = 0; row < multiplyTable.GetLength(0); row++)
            {
                for (int col = 0, mul = 2; col < multiplyTable.GetLength(1); col++, mul++)
                {
                    if (mul == 13)
                        continue;
                    Console.Write("{0 , 3} ", mul * (row + 1));
                    //Console.Write($"{row},{col} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
