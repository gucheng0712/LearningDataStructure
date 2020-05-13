using System;
using System.Diagnostics;

namespace _0030_ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution = MaxAreaOn2(1, 8, 6, 2, 5, 4, 8, 3, 7);
            Console.WriteLine(solution);

            Console.WriteLine("--------------------------------");

            int solution2 = MaxAreaOn(1, 8, 6, 2, 5, 4, 8, 3, 7);
            Console.WriteLine(solution2);
        }


        // O(n), 左右边界 i 和j, 向中间收敛: 双指针法
        static int MaxAreaOn(params int[] h)
        {
            int max = 0;
            int i = 0;
            int j = h.Length - 1;
            while (i <= j)
            {
                int minHeight = h[i] < h[j] ? h[i++] : h[j--];
                int area = (j - i + 1) * minHeight;
                max = Math.Max(max, area);
            }
            return max;
        }

        // O(n^2) 蛮力求解法
        static int MaxAreaOn2(params int[] height)
        {
            int max = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = 1; j < height.Length; j++)
                {
                    int minHeight = Math.Min(height[i], height[j]);
                    int area = (j - i) * minHeight;

                    max = Math.Max(area, max);
                }
            }
            return max;
        }
    }
}
