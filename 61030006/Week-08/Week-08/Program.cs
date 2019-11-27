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
            Queue<int> q = new Queue<int>();
            Console.WriteLine("-- enqueue 3 items -- ");
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.Write("Queue contains : ");
            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "q.Count  = {0}", q.Count);
            Console.WriteLine("q.Peek = {0}", q.Peek());

            Console.WriteLine("-- enqueue more items -- ");
            q.Enqueue(40);
            q.Enqueue(50);

            Console.Write("Queue contains : ");
            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "q.Count  = {0}", q.Count);
            Console.WriteLine("q.Peek = {0}", q.Peek());

            Console.WriteLine("-- dequeue -- ");
            int i = q.Dequeue();
            Console.WriteLine("i = {0}", i);

            Console.Write("Queue contains : ");
            foreach (var item in q)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(Environment.NewLine + "q.Count  = {0}", q.Count);
            Console.WriteLine("q.Peek = {0}", q.Peek());
            Console.ReadLine();
        }
    }
}
