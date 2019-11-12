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
            Hashtable north = new Hashtable();
            north.Add("50000", "CHIANGMAI");
            north.Add("20000", "LAMPANG");
            north.Add("64000", "SUKHOTHAI");
            north.Add("61000", "UTHAITHANI");
            north.Add("55000", "NAN");
            north.Add("65000", "PHITSANULOK");
            north.Add("54000", "PHRAE");
            north.Add("58000", "MAEHONGSON");
            north.Add("57000", "CHIANGRAI");
            north.Add("63000", "TAK");

            foreach (DictionaryEntry pcn in north)
               {
                
                    Console.WriteLine($"{pcn.Key} => {pcn.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Enter PostCode North :");
            string n = Console.ReadLine().ToUpper ();
               

            foreach(DictionaryEntry pnc in north)
            {
                if (pnc.Equals(pnc.Key))
                    Console.WriteLine($"{pnc.Key} => {pnc.Value }");
                       
                   

            }
         


            Console.ReadLine();

            }
        
    }
}
                

    

