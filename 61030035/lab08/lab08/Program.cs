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
            float[] GPS = new float[8];
            for(int n=0;n<GPS.Length;n++)
            {
                Console.Write($"GPS TREM{n + 1} : ");
                GPS[n] = float.Parse(Console.ReadLine());
            }
            foreach(float j in GPS)
            Console.Write($"{j,0:N}");
            Console.WriteLine();
            Console.WriteLine("GPA is {0,0:N}", GPS.Sum() / GPS.Length);
            Console.ReadLine();
        }
    }
}
