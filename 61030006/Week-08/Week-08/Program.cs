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
            string[] month =
            {
            "January",
                "February",
                "March",
                "Aprill",
                "May",
                "June",
                "July",
                "August",
                "September",
                "November",
                "December"
            };

            //var sortedValues = from x in month
            //                   orderby x.Length descending, x descending
            //                   select x;

            var sortedValues = from x in month
                               orderby x.Length descending, x descending
                               select x;

            foreach (string str in sortedValues)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
        }
}
