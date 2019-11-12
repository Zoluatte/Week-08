using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace lab08
    
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

            // Method ContainKey()
            Console.WriteLine("The  key element \"8\" is contain in the Hashtable weeks : " + weeks.ContainsKey("8"));

            // Method ContainValue()
            Console.WriteLine("The  key element \"Wednesday\" is contain in the Hashtable weeks : " + weeks.ContainsValue("Wednesday"));

            Console.ReadLine();
        }
    }
}
                

    

