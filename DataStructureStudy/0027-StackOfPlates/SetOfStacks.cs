using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Question:
///     Stack Of Plates:Stack of Plates: Imagine a (literal) stack of plates. If the stack gets too high, it might topple.
///     Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. 
///     Implement a data structure SetOfStacks that mimics this. SetOfStacks should be
///     composed of several stacks and should create a new stack once the previous one exceeds capacity.
///     
///     SetOfStacks.Push () and SetOfStacks.Pop() should behave identically to a single stack
///     (that is, Pop( ) should return the same values as it would if there were just a single stack).
///     Also, Implement a function popAt (int index) which performs a pop operation on a specific substack.
/// </summary>

namespace StackOfPlates
{
    class SetOfStacks
    {
        List<MyStack> stacks = new List<MyStack>();
        public int capacity;
        public SetOfStacks(int capacity)
        {
            this.capacity = capacity;
        }

        public MyStack GetLastStack()
        {
            if (stacks.Count == 0) return null;
            return stacks[stacks.Count - 1];
        }


        public void Push(int item)
        {
            MyStack last = GetLastStack();
            if (last != null && !last.IsFull())
            {
                last.Push(item);
            }
            else
            {
                MyStack stack = new MyStack(capacity);
                stack.Push(item);
                stacks.Add(stack);
            }
        }

        public int Pop()
        {
            MyStack last = GetLastStack();
            if (last == null) throw new NullReferenceException();
            int item = last.Pop();
            if (last.size == 0) stacks.Remove(stacks[stacks.Count - 1]);
            return item;
        }

        public bool IsEmpty()
        {
            MyStack last = GetLastStack();
            return last == null || last.IsEmpty();
        }

        public int PopAt(int index)
        {
            return LeftShift(index, true);
        }

        public int LeftShift(int index, bool removeTop)
        {
            MyStack stack = stacks[index];
            int removed_item;

            removed_item = (removeTop) ? stack.Pop() : stack.RemoveBottom();
            if (stack.IsEmpty())
            {
                stacks.Remove(stacks[index]);
            }
            else if (stacks.Count > index + 1)
            {
                int item = LeftShift(index+1,false);
                stack.Push(item);
            }
            return removed_item;
        }
    }
}