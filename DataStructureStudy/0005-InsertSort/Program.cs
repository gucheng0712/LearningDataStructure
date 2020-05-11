using System;

namespace InsertSort
{
    /// <summary>
    /// 插入排序（英语：Insertion Sort）是一种简单直观的排序算法。
    /// 它的工作原理是通过构建有序序列，对于未排序数据，在已排序序列中从后向前扫描，找到相应位置并插入。
    /// 在从后向前扫描过程中，需要反复把已排序元素逐步向后挪位，为最新元素提供插入空间。
    /// 
    /// 
    /// 时间复杂度:
    ///     平均: O(n^2)
    ///     最好: O(n)
    ///     最差: O(n^2)
    /// </summary>
    class MainClass
    {
        public static void InsertSort(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int iValue = dataArray[i];
                bool isInserted = false;
                // 拿到i位置的元素跟前面所有的元素作比较
                for (int j = i - 1; j >= 0; j--)
                {
                    if (dataArray[j] > iValue) // 如果发现比i大的,就让它向后移动
                    {
                        dataArray[j + 1] = dataArray[j];
                    }
                    else
                    {
                        //如果发现一个比i小的值,就不移动了
                        dataArray[j + 1] = iValue;
                        isInserted = true;
                        break;
                    }
                }
                if (!isInserted)
                {
                    dataArray[0] = iValue;
                }
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
