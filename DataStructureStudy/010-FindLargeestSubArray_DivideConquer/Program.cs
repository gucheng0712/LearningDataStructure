using System;

namespace FindLargeestSubArray_DivideConquer
{
    class MainClass
    {
        //最大子数组结构体
        struct SubArray
        {
            public int startIndex;
            public int endIndex;
            public int total;
        }

        public static void Main(string[] args)
        {
            int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 47 };
            int[] pf = new int[priceArray.Length - 1];//价格波动的数组
            for (int i = 1; i < priceArray.Length; i++)
            {
                pf[i - 1] = priceArray[i] - priceArray[i - 1];
            }

            SubArray sub = GetMaSubArray(0, pf.Length - 1, pf);
            Console.WriteLine(sub.startIndex);
            Console.WriteLine(sub.endIndex);

        }

        // 这个方法是用来取得 array 这个数从 low 到 high 之间的最大子数组
        static SubArray GetMaSubArray(int low, int high, int[] array)
        {
            if (low == high)
            {
                SubArray sub;
                sub.startIndex = low;
                sub.endIndex = high;
                sub.total = array[low];
                return sub;
            }
            int mid = (low + high) / 2;// 低区间 [low,mid] 高区间 [mid+1,high]
            SubArray subArrayLow = GetMaSubArray(low, mid, array);
            SubArray subArrayHigh = GetMaSubArray(mid + 1, high, array);

            // 从[low,mid]找到最大子数组[i,mid]
            int total = array[mid];
            int startIndex = mid;
            int totalTemp = 0;
            for (int i = mid; i >= low; i--)
            {
                totalTemp += array[i];
                if (totalTemp > total)
                {
                    total = totalTemp;
                    startIndex = i;
                }
            }

            // 从[mid+1,high]找到最大子数组[mid+1,j]
            int total2 = array[mid + 1];
            int endIndex = mid + 1;
            totalTemp = 0;
            for (int j = mid + 1; j <= high; j++)
            {
                totalTemp += array[j];
                if (totalTemp > total2)
                {
                    total2 = totalTemp;
                    endIndex = j;
                }
            }
            SubArray subArrayC;
            subArrayC.startIndex = startIndex;
            subArrayC.endIndex = endIndex;
            subArrayC.total = total + total2;
            if (subArrayLow.total > subArrayHigh.total && subArrayLow.total > subArrayC.total)
            {
                return subArrayLow;
            }
            else if (subArrayHigh.total > subArrayLow.total && subArrayHigh.total > subArrayC.total)
            {
                return subArrayHigh;
            }
            else
            {
                return subArrayC;
            }
        }
    }
}
