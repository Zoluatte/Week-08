using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace Week_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable weeks = new Hashtable();
            weeks.Add("1", "Sunday");
            weeks.Add("2", "Monday");
            weeks.Add("3", "Tuesday");
            weeks.Add("4", "Wednesday");
            weeks.Add("5", "Thursday");
            weeks.Add("6", "Friday");
            weeks.Add("7", "Saturday");

            Console.WriteLine("---- elements in Hashtable weeks ----");
            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }

            Console.WriteLine("\n---- weeks.Remove(\"4\"); ----");
            weeks.Remove("4");
            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }

            Console.WriteLine("\n---- weeks.Clear(); ----");
            weeks.Clear();
            foreach (DictionaryEntry day in weeks)
            {
                Console.WriteLine(day.Key + "   -   " + day.Value);
            }

            Console.ReadLine();
        }
    
    }
}
