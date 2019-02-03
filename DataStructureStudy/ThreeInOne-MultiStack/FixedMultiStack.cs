using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Approach 1: Fixed Division
/// 
/// We can divide the array in three equal parts and allow the individual stack to grow in that limited space.
/// 
/// For example:
///     For stack1, we will use [0, n/3).
///     For stack2, we will use [n/3, 2n/3).
///     For stack3, we will use [2n/3, n).
/// </summary>

namespace ThreeInOne_MultiStack
{
    class FixedMultiStack
    {
        int numOfStacks = 3;
        int stackCapacity;
        int[] values;
        int[] sizes;

        //Constructor for initialization
        public FixedMultiStack(int stackSize)
        {
            stackCapacity = stackSize;
            values = new int[stackSize * numOfStacks];
            sizes = new int[numOfStacks];
        }

        // Push value onto stack
        public void Push(int stackNum, int value)
        {
            if (IsFull(stackNum))
            {
                throw new IndexOutOfRangeException();
            }
            sizes[stackNum]++;
            values[IndexOfTop(stackNum)] = value;
        }

        // Pop value from stack
        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum)) // Check if the stack is empty
            {
                throw new IndexOutOfRangeException();
            }
           
            // Remove the top index of that stack
            int topIndex = IndexOfTop(stackNum);
            int value = values[topIndex];
            values[topIndex] = 0;
            sizes[stackNum]--;
            return value;
        }

        public int Peek(int stackNum)
        {
            if(IsEmpty(stackNum)) throw new IndexOutOfRangeException();

            return values[IndexOfTop(stackNum)];
        }


        // Check if the stack is empty
        private bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        // Check if the Stack is Full
        private bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        // Return the index of the top of the choosen stack
        private int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }
    }
}
