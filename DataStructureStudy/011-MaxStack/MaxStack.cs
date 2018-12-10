/*
 Stack with max.
    Design a max stack that supports push, pop, peek, peekMax and popMax.

    push(x) -- Push element x onto stack.
    pop() -- Remove the element on top of the stack and return it.
    peek() -- Get the element on the top.
    peekMax() -- Retrieve the maximum element in the stack.
    popMax() -- Retrieve the maximum element in the stack, and remove it. If you find more than one maximum elements, only remove the top-most one.

    Example 1:
        MaxStack stack = new MaxStack();
        stack.push(5); 
        stack.push(1);
        stack.push(5);
        stack.peek(); -> 5
        stack.popMax(); -> 5
        stack.peek(); -> 1
        stack.peekMax(); -> 5
        stack.pop(); -> 1
        stack.peek(); -> 5
    Note:
        1. -1e7 <= x <= 1e7
        2. Number of operations won't exceed 10000.
        3. The last four operations won't be called when stack is empty.
*/

using System;
using System.Collections.Generic;

namespace MaxStack
{
    public class MaxStack
    {
        Stack<int> stack = new Stack<int>();
        Stack<int> maxStack = new Stack<int>();

        public void Push(int item)
        {
            int max = maxStack.Count == 0 ? item : maxStack.Peek();
            maxStack.Push(max > item ? max : item);
            stack.Push(item);
        }

        public int Pop()
        {
            maxStack.Pop();
            return stack.Pop();
        }

        public int Peek()
        {
            return stack.Peek();
        }

        public int PeekMax()
        {
            return maxStack.Peek();
        }
        public int PopMax()
        {
            int max = PeekMax();
            Stack<int> buffer = new Stack<int>();
            while (Peek() != max)
            {
                buffer.Push(Pop());
            }
            Pop();
            while (buffer.Count != 0)
            {
                Push(buffer.Pop());
            }
            return max;
        }
    }
}
