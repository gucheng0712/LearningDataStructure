using System;
namespace BinaryHeap
{
    public class HeapSort_Array
    {
        public void HeapSort(int[] data)
        {

            // 根据大顶堆的性质: 数组的前半段元素为根节点,其余元素为叶节点
            for (int i = data.Length / 2 - 1; i >= 0; i--) // 从最底层的最后一个根节点开始进行大顶堆的调整
            {
                HeapAdjust(data, i, data.Length - 1); // 调整大顶堆
            }

            //得到大顶堆后开始堆排序
            //1. 将堆顶的元素(最大值)跟最后一个元素进行交换, 此时最大元素已经就绪，放到了最后.
            //2. 现在只需要管制前n-1个节点就可以了, 由于上一步将取后一个元素放到了根结点，
            //   所以前n-1个结点不再是大顶堆了，所以现在要调整堆为一个大顶堆，即Adjust
            //3. 一次筛选完成之后把堆顶元素再和最后一个交换，次大数就绪
            //4. 循环这个过程，最终得到有序序列
            for (int i = data.Length - 1; i > 0; i--)
            {
                Swap<int>(ref data[i], ref data[0]);
                HeapAdjust(data, 0, i);
            }

        }


        // 不使用递归调整大顶堆
        void HeapAdjust(int[] data, int currentIndex, int length)
        {
            int maxIndex = currentIndex;//记录此根节点、左子节点、右子节点 三者中最大值的位置
            while (true)
            {
                int leftChildIndex = 2 * currentIndex + 1; //左子节点在数组中的位置
                int rightChildIndex = 2 * currentIndex + 2; //右子节点在数组中的位置

                // 与左子节点进行比较
                if (leftChildIndex < length && data[leftChildIndex] > data[maxIndex])
                {
                    maxIndex = leftChildIndex;
                }
                //与右子节点进行比较
                if (rightChildIndex < length && data[rightChildIndex] > data[maxIndex])
                {
                    maxIndex = rightChildIndex;
                }
                // 如果maxIdex的值有所改变, 则表明需要调整
                if (currentIndex != maxIndex)
                {
                    Swap<int>(ref data[currentIndex], ref data[maxIndex]);
                    currentIndex = maxIndex;
                }
                else
                {
                    break;//跳出循环
                }
            }
        }

        // 通过递归来调整大顶堆
        void HeapAdjust_Recursion(int[] data, int index, int length)
        {
            int leftChildIndex = 2 * index + 1; //左子节点在数组中的位置
            int rightChildIndex = 2 * index + 2; //右子节点在数组中的位置
            int maxIndex = index;//记录此根节点、左子节点、右子节点 三者中最大值的位置

            // 与左子节点进行比较
            if (leftChildIndex < length && data[leftChildIndex] > data[maxIndex])
            {
                maxIndex = leftChildIndex;
            }

            //与右子节点进行比较
            if (rightChildIndex < length && data[rightChildIndex] > data[maxIndex])
            {
                maxIndex = rightChildIndex;
            }

            // 如果maxIdex的值有所改变, 则表明需要调整
            if (index != maxIndex)
            {
                Swap<int>(ref data[index], ref data[maxIndex]);//将左右节点中的大者与根节点进行交换（即：实现局部大顶堆）
                HeapAdjust(data, maxIndex, length);//以上次调整动作的large位置（为此次调整的根节点位置），进行递归调整
            }
        }

        // 交换两个数(泛型)
        void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}