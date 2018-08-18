using System;
using System.Collections.Generic;

namespace Stack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // BCL中的Stack<T>

            //Stack<char> stack = new Stack<char>();

            // my array implement Stack
            //IStack<char> stack = new SequenceStack<char>(30);

            // linked list implement Stack
            IStack<char> stack = new LinkedStack<char>();

            stack.Push('G');
            stack.Push('a');
            stack.Push('b');
            stack.Push('w');
            Console.WriteLine(stack.Count);
            stack.Pop();
            Console.WriteLine(stack.Count);
            stack.Peek();
            Console.WriteLine(stack.Count);
            stack.Clear();
            Console.WriteLine(stack.Count);
        }
    }
}
