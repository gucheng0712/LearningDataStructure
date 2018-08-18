using System;

namespace SelectSort
{
    class MainClass
    {
        public static void SelectSort(int[] dataArray)
        {
            // 因为最后一个数后面没有数所以不需要
            for (int i = 0; i < dataArray.Length - 1; i++)
            {
                //初始化最小的数
                int min = dataArray[i];

                // 初始化最小的数的index
                int minIndex = i;

                //因为是和i的后面的数作比较,所以起始位置为i+1
                for (int j = i + 1; j < dataArray.Length; j++)
                {
                    if (dataArray[j] < min)
                    {
                        min = dataArray[j];
                        minIndex = j;
                    }
                }

                // 如果minIndex和i不一样那就是说明找到了更小的数, 
                if (minIndex != i)
                {
                    //调换位置
                    int temp = dataArray[i];
                    dataArray[i] = dataArray[minIndex];
                    dataArray[minIndex] = temp;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
