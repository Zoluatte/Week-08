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
            TH.Add("61030001", "Kurngthai");
            TH.Add("61030006", "Khanita");
            TH.Add("61030007", "Khomkrit");
            TH.Add("61030008", "Janistar");
            TH.Add("61030009", "Janjira");
            TH.Add("61030017", "Napakorn");
            TH.Add("61030018", "Napat");
            TH.Add("61030020", "Natdanai");
            TH.Add("61030031", "Nakorn");
            TH.Add("61030035", "Phruksa");
            TH.Add("61030040", "Peerapon");
            TH.Add("61030045", "Maethaphon");
            TH.Add("61030054", "Supakorn");
            TH.Add("61030055", "Suphaphit");
            TH.Add("61030057", "Sakulrat");
            TH.Add("61030059", "Sirada");
            TH.Add("61030234", "Chonlada");
            TH.Add("61030238", "Naratip");
            TH.Add("61030242", "Warinrampai");
            TH.Add("61030243", "Widsawai");
           
            foreach (DictionaryEntry pcn in TH)
            {
                Console.WriteLine($"{pcn.Key} => {pcn.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Enter PostCode student :");
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
