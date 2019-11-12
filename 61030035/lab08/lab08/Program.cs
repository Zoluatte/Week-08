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
            ArrayList list1 = new ArrayList();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            Console.WriteLine("list1 count = {0}, capacity = {1}", list1.Count, list1.Capacity);
            ArrayList list2 = new ArrayList(20);
            Console.WriteLine("list2 count = {0}, capacity = {1}", list2.Count, list2.Capacity);
            ArrayList list3 = new ArrayList(list1);
            Console.WriteLine("list3 count = {0}, capacity = {1}", list3.Count, list3.Capacity);
            ArrayList list4 = new ArrayList(list2);
            Console.WriteLine("list4 count = {0}, capacity = {1}", list4.Count, list4.Capacity);
            Console.ReadLine();


        }
    }
}
                

    

