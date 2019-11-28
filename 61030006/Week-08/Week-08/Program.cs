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
            Hashtable TH = new Hashtable();
            TH.Add("71000", "Kanchanaburi");
            TH.Add("40000", "Khon Kaen");
            TH.Add("22000", "Chanthaburi");
            TH.Add("20000", "Chonburi");
            TH.Add("12000", "Pathum Thani");
            
           foreach (DictionaryEntry pcn in TH)
            {
                Console.WriteLine($"{pcn.Key} => {pcn.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Enter PostCode :");
            String n = Console.ReadLine().ToUpper();

            foreach (DictionaryEntry pnc in TH)
            {
                if (n.Equals(pnc.Key))
                    Console.WriteLine("{0}", pnc.Value);
            }

            Console.ReadLine();
        }
    
    }
}
