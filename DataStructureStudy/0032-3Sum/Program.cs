using System;
using System.Collections.Generic;

namespace _0032_3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = ThreeSum(-1, 0, 1, 2, -1, -4);
            foreach (var list in test)
            {
                foreach (var e in list)
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<List<int>> ThreeSum(params int[] nums)
        {
            // Sort the array for two pointer method
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            // 
            for (int k = 0; k < nums.Length - 2; k++)
            {
                if (k == 0 || (nums[k] != nums[k - 1]))
                {
                    int i = k + 1;
                    int j = nums.Length - 1;
                    int sum = 0 - nums[k];
                    while (i < j)
                    {
                        if (nums[i] + nums[j] == sum)
                        {
                            // 得到 sum 等于0 的列表
                            res.Add(new List<int>(new int[] { nums[k], nums[i], nums[j] }));

                            // 过滤相同的元素
                            while (nums[i] == nums[i + 1])
                                i++;
                            while (nums[j] == nums[j - 1])
                                j--;

                            i++;
                            j--;
                        }
                        else if (nums[i] + nums[j] < sum)
                        {
                            i++;
                        }
                        else
                        {
                            j--;
                        }
                    }
                }
            }
            return res;
        }

        public static List<List<int>> SumOfThree(params int[] nums)
        {
            List<List<int>> res = new List<List<int>>();
            for (int k = 0; k < nums.Length - 2; k++)
            {
                int i = k + 1;
                int j = nums.Length - 1;
                int sum = 0 - nums[k];
                while (i < j)
                {
                    if (nums[i] + nums[j] == sum)
                    {
                        res.Add(new List<int>(new int[] { nums[k], nums[i], nums[j] }));

                        while (nums[i] == nums[i + 1])
                        {
                            i++;
                        }
                        while (nums[j] == nums[j - 1])
                        {
                            j--;
                        }
                    }
                    else if (nums[i] + nums[j] < sum)
                    {
                        i++;
                    }
                    else
                    {
                        j--;
                    }
                }
            }

            return res;
        }

    }
}
