using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack1 = new Stack<string>();
            stack1.Push("************");
            stack1.Push("RED");
            stack1.Push("GREEN");
            stack1.Push("BLUE");
            stack1.Push("YELLOW");
            stack1.Push("***********");
            stack1.Push("** COLOR **");
            stack1.Push("***********");
            Console.WriteLine("The elements in the stack1 are as:");
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("The element RED contain in the stack " + stack1.Contains("RED"));
            Console.WriteLine("The element YELLOW contain in the stack " + stack1.Contains("YELLOW"));
            Console.WriteLine("The element BLACK contain in the stack " + stack1.Contains("BLACK"));
            Console.ReadLine();
        }
    }
}
