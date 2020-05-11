using System;
using System.Collections.Generic;

namespace Queue
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 使用BCL中的Queue
            //Queue<int> queue = new Queue<int>();
            //  IQueue<int> queue = new SeQueue<int>();
            IQueue<int> queue = new LinkedQueue<int>();
            queue.Enqueue(1211);
            queue.Enqueue(23333);
            queue.Enqueue(3456);
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count);
            queue.Dequeue();
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.Peek());
            queue.Clear();
            Console.WriteLine(queue.Count);

        }
    }
}
