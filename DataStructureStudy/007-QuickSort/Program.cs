using System;

namespace QuickSort
{
    class MainClass
    {
        /// <summary>
        /// 对数组dataArray中从index的left到right之间的数做排序
        /// </summary>
        /// <param name="dataArray">要排序的数组</param>
        /// <param name="leftIndex">要排序数据的开始index. </param>
        /// <param name="rightIndex">要排序数据的结束index. </param>
        public static void QuickSort(int[] dataArray, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                // 基准书(pivot) 如果比他小或者等于它的放在它左边,然后把比它大的放在它的右边
                int x = dataArray[leftIndex];

                //用来做循环的标志位
                int i = leftIndex;
                int j = rightIndex;
                while (i < j) // 当i==j的时候,说明我们找到了中间位置,这个中间位置就是基准数应该所在的位置
                {

                    // 从后往前比较, 找一个小于等于基准数x的数字, 替换掉那个位于i位置的数字
                    while (i < j)
                    {
                        if (dataArray[j] <= x) //  找到了一个小于等于基准数的数字, 所以应该把它放在基准数x的左边
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
                        if (dataArray[i] > x)
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
                dataArray[i] = x;// left - i - right.


                //接着使用(递归)recursion
                // i 已经确定下来不会变,所以不用计算
                QuickSort(dataArray, leftIndex, i - 1);
                QuickSort(dataArray, i + 1, leftIndex);
            }
        }

        public static void Main(string[] args)
        {
            int[] data = { 42, 20, 17, 27, 13, 8, 17, 48 };
            QuickSort(data, 0, data.Length - 1);
            foreach (var item in data)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
