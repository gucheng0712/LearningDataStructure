using System;

namespace MergeSort
{
    /// <summary>
    /// 归并排序（MERGE-SORT）是建立在归并操作上的一种有效的排序算法,该算法是采用分治法（Divide and Conquer）的一个非常典型的应用。
    /// 将已有序的子序列合并，得到完全有序的序列；即先使每个子序列有序，再使子序列段间有序。
    /// 
    /// 
    /// 时间复杂度:
    ///     平均:O(nlogn)
    ///     最好:O(nlogn)
    ///     最差:O(nlogn)
    /// </summary>
    class MainClass
    {
        //Before Sort: 3  1  23  15  1   8   5  22 
        //    Sorting: 1  3  23  15  1   8   5  22 
        //    Sorting: 1  3  15  23  1   8   5  22 
        //    Sorting: 1  3  15  23  1   8   5  22 
        //    Sorting: 1  3  15  23  1   8   5  22 
        //    Sorting: 1  3  15  23  1   8   5  22 
        //    Sorting: 1  3  15  23  1   5   8  22 
        //    Sorting: 1  1   3   5  8  15  22  23 
        public static void Main(string[] args)
        {
            int[] myArray = { 3, 1, 23, 15, 1, 8, 5, 22 };
            Console.Write("Before Sort: ");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            MergeSort(myArray);
        }

        public static void MergeSort(int[] array)
        {
            // 把temp数组定义在这里是必要的. 
            // 因为如果定义在排序过程中,由于递归的原因,这个temp 数组会不停的创建从而导致性能问题.
            int[] temp = new int[array.Length];
            MergeSort(array, temp, 0, array.Length - 1);
        }
        public static void MergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd) return;//子数组的长度大于1，则进入下面的递归处理

            int mid = (leftStart + rightEnd) / 2;//子数组划分成两个的位置

            MergeSort(array, temp, leftStart, mid);//对划分出来的左侧子数组进行递归划分 leftStart ~ mid
            MergeSort(array, temp, mid + 1, rightEnd);//对划分出来的右侧子数组进行递归划分 mid+1 ~ rightend
            Merge(array, temp, leftStart, rightEnd);//对左右子数组进行有序的整合（归并排序的核心部分）
        }

        //归并排序的核心部分：将两个有序的左右子数组，合并成一个有序的数组
        public static void Merge(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2; //左边的数组的结束为止
            int rightStart = leftEnd + 1; // 右边数组的开始为止
            int size = rightEnd - leftStart + 1; // 需要合并的两个数组的总数

            int leftIndex = leftStart; // 左边数组的index
            int rightIndex = rightStart;// 右边数组的Index
            int tempIndex = leftStart;// temp数组的Index

            //进行左右子表的遍历，如果其中有一个子表遍历完，则跳出循环
            while (leftIndex <= leftEnd && rightIndex <= rightEnd)
            {
                if (array[leftIndex] <= array[rightIndex])
                {
                    temp[tempIndex++] = array[leftIndex++];
                }
                else
                {
                    temp[tempIndex++] = array[rightIndex++];
                }
            }


            //有一侧子数组遍历完后，跳出循环，将另外一侧子表剩下的数放入暂存数组中
            while (leftIndex <= leftEnd)
            {
                temp[tempIndex++] = array[leftIndex++];
            }
            while (rightIndex <= rightEnd)
            {
                temp[tempIndex++] = array[rightIndex++];
            }
            //或者可以使用数组的copy方法
            //Array.Copy(array, leftIndex, temp, tempIndex, leftEnd - leftIndex + 1);
            //Array.Copy(array, rightIndex, temp, tempIndex, rightEnd - rightIndex + 1);

            Array.Copy(temp, leftStart, array, leftStart, size);
            Console.Write("Sorting: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }


    }
}

