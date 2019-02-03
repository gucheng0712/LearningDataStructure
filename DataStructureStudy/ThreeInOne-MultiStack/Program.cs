using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Question: Three in One: Describe how you could use a single array to implement three stacks.
/// 
/// Solution: Like many problems, this one somewhat depends on how well we'd like to support these stacks. 
/// If we're okay with simply allocating a fixed amount of space for each stack, we can do that.
/// This may mean though that one stack runs out of space, while the others are nearly empty
/// 
/// Alternatively, we can be flexible in our space allocation, but this significantly increases the complexity of the problem.
/// </summary>

namespace ThreeInOne_MultiStack
{
    class Program
    {
        static void Main(string[] args)
        {
            FlexMutiStackTest();

            Console.ReadKey();
        }

        static void FixedMutiStackTest()
        {
            FixedMultiStack fms = new FixedMultiStack(5);

            fms.Push(1, 1);
            fms.Push(0, 1);
            fms.Push(2, 2);
            fms.Push(1, 5);
            fms.Push(0, 3);
            fms.Push(2, 8);
            Console.WriteLine(fms.Pop(0));
            Console.WriteLine(fms.Pop(1));
            Console.WriteLine(fms.Pop(2) + "\n");

            Console.WriteLine(fms.Peek(0));
            Console.WriteLine(fms.Peek(1));
            Console.WriteLine(fms.Peek(2));
        }

        static void FlexMutiStackTest()
        {
            FlexibleMutiStack fms = new FlexibleMutiStack(3,10);
            for (int i = 0; i < 10; i++)
            {
                fms.Push(0, 1);
                fms.Push(0, 3);
            }
            fms.Push(1, 1);
        
            fms.Push(2, 2);
            fms.Push(1, 5);

            fms.Push(2, 8);

            Console.WriteLine(fms.Pop(0));
            Console.WriteLine(fms.Pop(1));
            Console.WriteLine(fms.Pop(2) + "\n");

            Console.WriteLine(fms.Peek(0));
            Console.WriteLine(fms.Peek(1));
            Console.WriteLine(fms.Peek(2));
        }
    }
}
