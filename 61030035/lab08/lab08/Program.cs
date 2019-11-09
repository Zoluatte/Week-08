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
            string[] month_er = Array.FindAll(month, ele => ele.EndsWith("ber"));
            string[] copy_er = new string[month_er.Length];
            Array.Copy(month_er, copy_er, month_er.Length);
            string[] month_ry = Array.FindAll(month, ele => ele.EndsWith("ry"));
            string[] copy_ry = new string[month_ry.Length];
            Array.Copy(month_ry, copy_ry, month_ry.Length);
            //foreach (string str in copy_er)
            // Console.WriteLine(str);

            foreach (string str in copy_ry)
                Console.WriteLine(str);
            Console.ReadLine();
        }
                
        }
    }

