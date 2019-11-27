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
            int[] data = { 51, 58, 14, 20, -5, 61, 7, 21, 6 };
            Console.WriteLine("Length of data = {0}", data.Length);
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.ReadLine();

        
        }
    }
}
