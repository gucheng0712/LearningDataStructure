using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Question: 
///         Queue via Stacks: Implement a MyQueue class which implements a queue using two stacks
///         
///  Solution:
///     Since the major difference between a queue and a stack is the order (first-in first-out vs.last-in first-out), 
///     we know that we need to modify peek() and pop() to go in reverse order.
///     We can use our second stack to reverse the order of the elements (by popping 51 and pushing the elements on to 52). 
///     In such an implementation, on each peek() and pop() operation, we would pop everything from s1 onto s2, 
///     perform the peek / pop operation, and then push everything back.
///     This will work, but if two pop / peeks are performed back-to-back, we're needlessly moving elements. 
///     We can implement a "lazy" approach where we let the elements sit in s 2 until we absolutely must reverse the elements.
///     
///     In this approach, stackNewest has the newest elements on top and stackOldest has the oldest elements on top.
///     When we dequeue an element, we want to remove the oldest element first, and so we dequeue from stackOldest. 
///     If stackOldest is empty, then we want to transfer all elements from stackNewest into this stack in reverse order. 
///     To insert an element, we push onto stac kNewest, since it has the newest elements on top.
/// </summary>

namespace QueueViaStacks
{
    class MyQueue<T>
    {
        Stack<T> oldStack;
        Stack<T> newStack;

        public MyQueue()
        {
            oldStack = new Stack<T>();
            newStack = new Stack<T>();
        }

        public void Enqueue(T item)
        {
            newStack.Push(item);
        }
        
        public T Peek()
        {
            ShiftStack();
            return oldStack.Peek();
        }

        public T Pop()
        {
            ShiftStack();
            return oldStack.Pop();
        }

        void ShiftStack()
        {
            if (oldStack.Count == 0)
            {
                while (newStack.Count != 0)
                {
                    oldStack.Push(newStack.Pop());
                }
            }
        }

    }
}
