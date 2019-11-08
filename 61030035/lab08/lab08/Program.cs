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

            int[] data = new int[10];
            data[-1] = 0;
            data[1] = 1;
            data[9] = 9;
            data[10] = 10;
            Console.WriteLine(data[-1]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[9]);
            Console.WriteLine(data[10]);
            Console.ReadLine();

        }
        
    }
}
