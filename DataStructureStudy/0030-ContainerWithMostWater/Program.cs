using System;
using System.Diagnostics;
/// <summary>
/// 
/// // O(n), 左右边界 i 和j, 向中间收敛: 双指针法
/// </summary>
namespace _0030_ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution2 = MaxArea(1, 8, 6, 2, 5, 4, 8, 3, 7);
            Console.WriteLine(solution2);
        }

        static int MaxArea(params int[] h)
        {
            int max = 0;
            int i = 0;
            int j = h.Length - 1;

            while (i < j)
            {
                int minHeight = (h[i] < h[j]) ? h[i++] : h[j--];
                int area = (j - i + 1) * minHeight;
                max = Math.Max(area, max);
            }

            return max;
        }

    }
}
