using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  Approach 2: Flexible Divisions
///  
/// A second approach is to allow the stack blocks to be flexible in size. 
/// When one stack exceeds its initial capacity, we grow the allowable capacity and shift elements as necessary
/// </summary>

namespace ThreeInOne_MultiStack
{

    public class FlexibleMutiStack
    {
        private class StackInfo
        {
            public int start;
            public int size;
            public int capacity;

            public StackInfo(int start, int capacity)
            {
                this.start = start;
                this.capacity = capacity;
            }
        }

        StackInfo[] info;
        public int[] values;

        //Constructor
        public FlexibleMutiStack(int numOfStacks, int defaultSize)
        {
            // Create metadata for all stacks
            info = new StackInfo[numOfStacks];
            for (int i = 0; i < numOfStacks; i++)
            {
                info[i] = new StackInfo(defaultSize * i, defaultSize);
            }
            values = new int[numOfStacks * defaultSize];
        }

        // Push value onto stack num, shifting/expanding stacks as necessary.
        // Throws exception if all stacks are full
        public void Push(int stackNum, int value)
        {
            if (AllStackAreFull())
            {
                throw new IndexOutOfRangeException();
            }

            // If this stack is full, expend it
            StackInfo stack = info[stackNum];
            if (IsFull(stackNum))
            {
                Expend(stackNum);
            }

            // Find the index of the top element in the array + 1, and increment the stack pointer
            stack.size++;
            values[LastElementIndex(stackNum)] = value;
        }

        // Remove value from stack
        public int Pop(int stackNum)
        {
            StackInfo stack = info[stackNum];
            if (IsEmpty(stackNum)) throw new IndexOutOfRangeException();

            // Remove last element
            int value = values[LastElementIndex(stackNum)];
            values[LastElementIndex(stackNum)] = 0;//Clear item
            stack.size--;// Shrink size
            return value;
        }

        // Get Top elemtn from stack
        public int Peek(int stackNum)
        {
            StackInfo stack = info[stackNum];
            return values[LastElementIndex(stackNum)];
        }

        // Expand stack by shifting over other stacks
        private void Expend(int stackNum)
        {
            Shift((stackNum + 1) % info.Length);
            info[stackNum].capacity++;
        }

        // Shift items in stack over by one element. 
        // If we have available capacity, we ill end up shrinking the stack by one element.
        // If we don't have available capacity, then we will need to shift the next stack over too.
        private void Shift(int stackNum)
        {
            Console.WriteLine("/// Shifting " + stackNum);
            StackInfo stack = info[stackNum];

            // If this stack is at its full capacity, then you need to move the next stack over by one element.
            // This stack can now claim the freed index
            if (stack.size >= stack.capacity)
            {
                int nextStack = (stackNum + 1) % info.Length;
                Shift(nextStack);
                stack.capacity++; // Claim the lost index for the next stack
            }

            // Shift all elements in stack over by one
            int index = LastCapacityIndex(stackNum);
            while (IsWithInStackCapacity(index, stackNum))
            {
                values[index] = values[PreviousIndex(index)];
                index = PreviousIndex(index);
            }
        }



        // Check if an index on the full array is within the stack boundaries. 
        // The stack can wrap around to the start of the array
        public bool IsWithInStackCapacity(int index, int stackNum)
        {
            // If Outside of bounds of array, return false
            if (index < 0 || index >= values.Length)
            {
                return false;
            }

            // If Index wraps around, adjust it
            StackInfo stack = info[stackNum];
            int contiguousIndex = index < stack.start ? index + values.Length : index;
            int end = stack.start + stack.capacity;

            return stack.start <= contiguousIndex && contiguousIndex < end;
        }

        public int LastCapacityIndex(int stackNum)
        {
            StackInfo stack = info[stackNum];
            return AdjustIndex(stack.start + stack.capacity - 1);
        }

        public int LastElementIndex(int stackNum)
        {
            StackInfo stack = info[stackNum];
            return AdjustIndex(stack.start + stack.size - 1);
        }

        public bool IsFull(int stackNum)
        {
            StackInfo stack = info[stackNum];
            return stack.size == stack.capacity;
        }
        public bool IsEmpty(int stackNum)
        {
            StackInfo stack = info[stackNum];
            return stack.size == 0;
        }

        // Get index before this index, adjusted for wrap around
        private int PreviousIndex(int index)
        {
            return AdjustIndex(index - 1);
        }

        // Return true if all the stacks are full
        private bool AllStackAreFull()
        {
            return NumOfElements() == values.Length;
        }

        // Return the number of elements actually present in the stack
        private int NumOfElements()
        {
            int size = 0;
            foreach (StackInfo i in info)
            {
                size += i.size;
            }
            return size;
        }

        // Adjust index to be within the range of 0 --> ength-1
        public int AdjustIndex(int index)
        {
            // In C# the mod operator can return neg values. For examle,
            // (-11%5)will return -1, not 4. we actually want to value be 4
            int max = values.Length;
            return ((index % max) + max) % max;
        }
    }
}
