using System;

namespace _0029_MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = MoveZeros(0, 1, 0, 3, 12);

            foreach (var item in arr)
            {
                Console.Write("{0}", item + " ");
            }
        }

        static int[] MoveZeros(params int[] nums)
        {
            int nonZeroIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[nonZeroIndex] = nums[i];
                    if (i != nonZeroIndex)
                    {
                        nums[i] = 0;
                    }
                    nonZeroIndex++;
                }
            }

            return nums;
        }
    }
}
