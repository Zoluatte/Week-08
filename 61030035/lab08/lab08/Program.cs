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
            string[] month = {"JANUARY","FEBRUARY","MARCH","APRIL","MAY","JUNE","JULY",
                    "AUGUST","SEPTEMBER","OCTOBER","NOVEMBER","DECEMBER",
            };
            string[] month_RY = Array.FindAll(month, element => element.EndsWith("RY"));
            string[] copy_RY = new string[month_RY.Length];
            Array.Copy(month_RY, copy_RY, month_RY.Length);
            

            foreach (string str in copy_RY)
             Console.WriteLine(str);

            
            Console.ReadLine();
        }
                
        }
    }

