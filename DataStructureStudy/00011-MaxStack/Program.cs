using System;

namespace MaxStack
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            Console.WriteLine("Peek Stack After Push 5: " + stack.Peek());
            stack.Push(1);
            Console.WriteLine("Peek Stack After Push 1: " + stack.Peek());
            stack.Push(3);
            Console.WriteLine("Peek Stack After Push 3: " + stack.Peek());
            Console.WriteLine("Peek the Max Stack " + stack.PeekMax());
            stack.PopMax();
            Console.WriteLine("Peek the Max Stack After Pop the Max: " + stack.PeekMax());
            stack.Pop();
            Console.WriteLine("Peek Stack After Pop: " + stack.Peek());
        }

    }
}
