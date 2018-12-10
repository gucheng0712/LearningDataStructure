using System;
namespace FindLargestSubArray
{
    public class ViolentMethod
    {

        public int[] FindLargestSubArray(params int[] arr)
        {
            int total = arr[0]; // 默认第一个元素是最大数组
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                // 取得以 i 为子数组起点的所有子数组
                for (int j = 0; j < arr.Length; j++)
                {
                    int totalTemp = 0; // 临时最大子数组的和
                    for (int k = i; k < j + 1; k++)
                    {
                        totalTemp += arr[k];
                    }
                    if (totalTemp > total) // 如果比原来的大, 那么就更新子数组所在的indexs
                    {
                        total = totalTemp;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }

            int[] subArray = new int[endIndex - startIndex + 1];
            int subIndex = 0;

            // 得到最大子数组, 通过遍历初始索引到尾部索引
            for (int i = startIndex; i <= endIndex; i++)
            {
                subArray[subIndex] = arr[i];
                subIndex++;
            }
            return subArray;
        }

    }
}
