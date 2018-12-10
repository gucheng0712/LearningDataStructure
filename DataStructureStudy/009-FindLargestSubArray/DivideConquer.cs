using System;
namespace FindLargestSubArray
{

    public struct SubArray
    {
        public int startIndex;
        public int endIndex;
        public int total;

        public SubArray(int startIndex, int endIndex, int total)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
            this.total = total;
        }
    }

    public class DivideConquer
    {

        // 这个方法是用来虚的 arr 这个数组中的从 low 到 high 之间的最大子数组
        public SubArray FindLargestSubArray(int low, int high, params int[] arr)
        {
            //终止条件 -- 当low和hig相等后就终止
            if (low == high)
            {
                return new SubArray(low, high, arr[low]);
            }

            int mid = (low + high) / 2; // 现在有两个区间: 低区间,[low, mid]. 高区间,[mid+1,high]

            // 第一种情况,最大子数组的 startIndex 和 endIndex 都在低区间
            SubArray subArr1 = FindLargestSubArray(low, mid, arr);

            // 第二种情况,最大子数组的 startIndex 和 endIndex 都在高区间
            SubArray subArr2 = FindLargestSubArray(mid + 1, high, arr);


            // 第三种情况, 最大子数组的startIndex 在低区间, endIndex 在高区间

            int tempTotal = 0;
            // 从[low, mid] 找到最大子数组 [i, mid]
            // 因为mid是不变的所以一定是从mid往前数并且是连续的数

            int startIndex = mid;
            int total1 = arr[mid];

            for (int i = mid; i >= low; i--)
            {
                tempTotal += arr[i];
                if (tempTotal > total1) // 
                {
                    total1 = tempTotal;
                    startIndex = i;
                }
            }

            // 从[mid+1, high] 找到最大子数组 [mid+1, j]
            //因为mid是不变的所以一定是从mid+1往后数并且是连续的数
            tempTotal = 0;

            int endIndex = mid + 1;
            int total2 = arr[mid + 1];

            for (int j = mid + 1; j <= high; j++)
            {
                tempTotal += arr[j];
                if (tempTotal > total2)
                {
                    total2 = tempTotal;
                    endIndex = j;
                }
            }

            SubArray subArr3 = new SubArray(startIndex, endIndex, total1 + total2);


            if (subArr1.total >= subArr2.total && subArr1.total >= subArr3.total)
            {
                return subArr1;
            }
            else if (subArr2.total >= subArr1.total && subArr2.total >= subArr3.total)
            {
                return subArr2;
            }
            else
            {
                return subArr3;
            }
        }
    }
}
