using System;

namespace InsertSort
{

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
