using System;

namespace FindLargeestSubArray_ViolentMethod
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 47 };
            int[] pf = new int[priceArray.Length - 1];//价格波动的数组
            for (int i = 1; i < priceArray.Length; i++)
            {
                pf[i - 1] = priceArray[i] - priceArray[i - 1];
            }

            int total = pf[0]; // 默认第一个元素是最大数组
            int startIndex = 0;
            int endIndex = 0;

            //
            for (int i = 0; i < pf.Length; i++)
            {
                //取得以i为子数组起点的所有子数组
                for (int j = i; j < pf.Length; j++)
                {
                    int totalTemp = 0;
                    for (int k = i; k < j + 1; k++)
                    {
                        totalTemp += pf[k];
                    }
                    if (totalTemp > total)
                    {
                        total = totalTemp;
                        startIndex = i;
                        endIndex = j;
                    }
                }
            }
            Console.WriteLine("StartIndex: " + startIndex);
            Console.WriteLine("EndIndex: " + endIndex);
        }
    }
}
