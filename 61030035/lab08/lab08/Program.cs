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
            Hashtable student = new Hashtable();
            student.Add("61030001", "KURNGTHAI SUMPRUNG");
            student.Add("61030006", "KHANITA VIRIYADECHOCHAI");
            student.Add("61030007", "KHOMKRIT DEANGNUAN");
            student.Add("61030008", "JANISTAR PIMPATHONG");
            student.Add("61030009", "JANJIRA INTARASUK");
            student.Add("61030017", "NAPAKORN SUKKASEM");
            student.Add("61030018", "NAPAT KUMSEN");
            student.Add("61030020", "NATDANAI IAMSAAD");
            student.Add("61030021", "NATTAPAT SRISANAM");
            student.Add("61030031", "NAKORN SRIKASEM");
            student.Add("61030035", "PHRUKSA KAEWMANEE");
            student.Add("61030040", "PEERAPON SAYYOD");
            student.Add("61030045", "MAETHAPHON CHANGART");
            student.Add("61030050", "WATSAPHON KHUNTHORN");
            student.Add("61030054", "SUPAKHON MAPACHUM");
            student.Add("61030055", "SUPHAPHIT SUKA");
            student.Add("61030057", "SAKULRAT PLUKSAKUL");
            student.Add("61030059", "SIRADA SOONTHORN");
            student.Add("61030060", "SUPHON SAEJIA");
            student.Add("61030234", "CHONELADA PHONDEE");
            student.Add("61030238", "NARATIP SANGJANDA");
            student.Add("61030242", "WARINRAMPAI KHUNPARKDEE");
            student.Add("61030243", "WIDSAWA DHAMCHOMSAP");


            foreach (DictionaryEntry com in student)
               {
                
                    Console.WriteLine($"{com.Key} => {com.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("Enter PostCode Student :");
            string s = Console.ReadLine().ToUpper ();
               

            foreach(DictionaryEntry com in student)
            {
                if(s.Equals(com.Key))
                Console.WriteLine("{0}", com.Value);
            }
                   Console.ReadLine();

            }
        
    }
}


  
                

    

