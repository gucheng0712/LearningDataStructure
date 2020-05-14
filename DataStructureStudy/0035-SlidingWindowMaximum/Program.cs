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
            int max;
            int[] res = new int[nums.Length - k + 1];

            //遍历所有"窗口"
            for (int i = 0; i <= nums.Length - k; i++)
            {
                max = nums[i]; // 初始化最大值

                // 通过遍历来比较 " 窗口" 里面的数的大小
                for (int j = 1; j < k; j++)
                {
                    if (nums[i + j] > max)
                    {
                        max = nums[i + j];
                    }
                }
                // 把最大的数添加到输出数组里
                res[i] = max;
            }
            return res;
        }
    }
}
