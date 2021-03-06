﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace _0034_LargestRectangleInHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StackSolution_On(new int[] { 2, 1, 5, 6, 2, 3 }));
        }

        static int StackSolution_On(int[] heights)
        {
            int maxArea = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1); // push an initial value -1 for calculate offset later
            for (int i = 0; i < heights.Length; i++)
            {
                // to make sure the stack is in order from small to large
                while (stack.Peek() != -1 && heights[stack.Peek()] >= heights[i])
                {
                    // Pop the smaller element
                    int lastElementIndex = stack.Pop();
                    int area = heights[lastElementIndex] * (i - stack.Peek() - 1);
                    maxArea = Math.Max(maxArea, area);
                }
                stack.Push(i); // push the larger elements into the stack
            }

            // check if stack still has elements then calculate these elements size
            while (stack.Peek() != -1)
            {
                int lastIndex = stack.Pop();
                int area = heights[lastIndex] * (heights.Length - stack.Peek() - 1);
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }
    }
}
