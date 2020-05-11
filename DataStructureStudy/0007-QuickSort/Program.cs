using System;

namespace QuickSort
{
    class MainClass
    {
        /// <summary>
        /// 快速排序（Quicksort). 它采用了一种分治的策略，通常称其为分治法(Divide-and-ConquerMethod)。
        /// 分治法的基本思想是：将原问题分解为若干个规模更小但结构与原问题相似的子问题。递归地解这些子问题，然后将这些子问题的解组合为原问题的解。
        /// 利用分治法可将快速排序的分为三步：
        /// 1. 在数据集之中，选择一个元素作为”基准”（pivot）。
        /// 
        /// 2. 所有小于”基准”的元素，都移到”基准”的左边；所有大于”基准”的元素，都移到”基准”的右边。
        ///    这个操作称为分区 (partition) 操作，分区操作结束后，基准元素所处的位置就是最终排序后它的位置。
        /// 
        /// 3. 对”基准”左边和右边的两个子集，不断重复第一步和第二步，直到所有子集只剩下一个元素为止。
        /// 
        /// 
        /// 时间复杂度:
        ///     平均:O(nlogn)
        ///     最好:O(nlogn)
        ///     最差:O(n^2)
        /// </summary>
        /// 
        /// <param name="dataArray">要排序的数组</param>
        /// <param name="leftIndex">要排序数据的头部index. </param>
        /// <param name="rightIndex">要排序数据的尾部index. </param>
        public static void QuickSort(int[] dataArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                // 基准数(pivot) 如果比他小或者等于它的放在它左边,然后把比它大的放在它的右边
                int pivot = dataArray[leftIndex];

                //用来做循环的标志位
                int i = leftIndex;
                int j = rightIndex;
                while (i < j) // 当i==j的时候,说明我们找到了中间位置,这个中间位置就是基准数应该所在的位置
                {
                    // 从后往前比较, 找一个小于等于基准数x的数字, 替换掉那个位于i位置的数字
                    while (i < j)
                    {
                        if (dataArray[j] <= pivot)
                        {
                            dataArray[i] = dataArray[j];
                            break;
                        }
                        else
                        {
                            j--; // 向左移动到下一个数字,然后做比较
                        }
                    }

                    // 从前往后作比较, 找一个大于基准数x的数字, 替换掉那个位于j位置的数字
                    while (i < j)
                    {
                        if (dataArray[i] > pivot)
                        {
                            dataArray[j] = dataArray[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                }
                // 跳出循环后, 现在i==j了, 这样i就是中间位置的,所以把基准数放在i的位置
                // 这样就分成了两个区间因为 i 的位置已经确定下来了是中间数
                // 就是说在i左边的数虽然不是有序的但比i要小;
                // 而在i右边的数虽然不是有序的但比i要大
                dataArray[i] = pivot;// left - i - right.

                //接着使用(递归)recursion
                // i 已经确定下来不会变,所以不用计算
                QuickSort(dataArray, leftIndex, i - 1);
                QuickSort(dataArray, i + 1, rightIndex);
            }
        }


        public static void QuickSortClean(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int first = low, last = high;

            //此时a[low]被保存到pivot，所以元素a[low]可以当作是一个空位，用于保存数据，之后每赋值一次，也会有一个位置空出来，直到last==first，此时arr[last]==arr[first]=pivot
            int pivot = arr[low];
            while (first < last)
            {
                while (first < last && arr[last] >= pivot)
                {
                    last--;
                }
                arr[first] = arr[last];

                while (first < last && arr[first] <= pivot)
                {
                    first++;
                }
                arr[last] = arr[first];
            }

            // 跳出循环后, 现在i==j了, 这样i就是中间位置的,所以把基准数放在i的位置
            // 这样就分成了两个区间因为 i 的位置已经确定下来了是中间数
            // 就是说在i左边的数虽然不是有序的但比i要小;
            // 而在i右边的数虽然不是有序的但比i要大
            arr[first] = pivot;

            //递归排序数组左边的元素
            QuickSortClean(arr, low, first - 1);
            //递归排序右边的元素
            QuickSortClean(arr, first + 1, high);
        }

        public static void Main(string[] args)
        {
            int[] data = { 42, 20, 17, 27, 13, 8, 17, 48 };
            QuickSortClean(data, 0, data.Length - 1);
            foreach (var item in data)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
