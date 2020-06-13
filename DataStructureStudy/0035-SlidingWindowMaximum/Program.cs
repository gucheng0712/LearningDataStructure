using System;
using System.Collections.Generic;

namespace SlidingWindowMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3))
            {
                Console.Write(item + " ");
            }
        }

        /// <summary>
        ///  最简便的方法
        /// </summary>
        /// <param name="nums">输入数组</param>
        /// <param name="k">窗口大小</param>
        /// <returns></returns>
        static int[] MaxSlidingWindow(int[] nums, int k)
        {
            int[] res = new int[nums.Length - k + 1];

            //遍历所有"窗口"
            for (int i = 0; i <= nums.Length - k; i++)
            {
                int max = nums[i]; // 初始化第一个element为目前最大值
                // 通过遍历来比较 " 窗口" 里面的数的大小
                for (int j = 1; j < k; j++)
                {
                    max = Math.Max(max, nums[i + j]);
                }
                // 把最大的数添加到输出数组里
                res[i] = max;
            }
            return res;
        }
    }
}
