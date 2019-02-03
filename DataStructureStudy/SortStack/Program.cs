using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Question:
///     Sort Stack: Write a program to sort a stack such that the smallest items are on the top. 
///     You can use an additional temporary stack, but you may not copy the elements into any other data structure
///     (such as an array). The stack supports the following operations: push, pop, peek, and isEmpty.
/// </summary>

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Sort(Stack<int> s)
        {
            Stack<int> tempStack = new Stack<int>();
            while (s.Count != 0)
            {
                // Insert each element in s in sorted order into tempStack
                int tmp = s.Pop();
                while (tempStack.Count != 0 && tempStack.Peek() > tmp)
                {
                    s.Push(tempStack.Pop());
                }
                tempStack.Push(tmp);
            }

            // Copy the element back to s
            while (tempStack.Count!=0)
            {
                s.Push(tempStack.Pop());
            }
        }
    }
}
