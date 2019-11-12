using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[7][];
            int count = 0;
            for (int row = 0; row < jagged.GetLength(0); ++row)
            {
                Console.Write("\nRow {0}:", row);
                jagged[row] = new int[row + 1];
                for (int index = 0; index < row + 1; ++index)
                {
                    ++count;
                    jagged[row][index] = count;
                    Console.Write(" {0}", count);
                }
            }
            Console.WriteLine("\n\nTotals");
            for (int row = 0; row < jagged.GetLength(0); ++row)
            {
                int total = 0;
                for (int index = 0; index < jagged[row].GetLength(0); ++index)
                {
                    total += jagged[row][index];
                }
                Console.Write("\nRow {0}: {1}", row, total);
            }
            Console.ReadLine();
        }
    }
    }
                

    

