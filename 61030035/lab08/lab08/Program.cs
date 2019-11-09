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
            string[] array1 = { "cat", "dog", "carrot", "bird" };
            //
            // ค้นหาสมาชิกตัวแรกที่มีค่าตามกำหนด
            //
            string value1 = Array.Find(array1, element => element.StartsWith("car", StringComparison.Ordinal));

            string value2 = Array.Find(array1, element => element.StartsWith("fish", StringComparison.Ordinal));

            //
            // ค้นหาสมาชิกตัวแรกที่มีความยาว string ตามกำหนด
            //
            string value3 = Array.Find(array1, element => element.Length == 3);
            //
            // ค้นหา string ที่มีความยาวไม่เกินค่าที่กำหนด
            //
            string[] array2 = Array.FindAll(array1, element => element.Length <= 4);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(string.Join(",", array2));
            Console.ReadLine();
        }
    }
}
