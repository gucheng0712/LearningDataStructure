/*
假定我们知道sering公司出售一段长度为n的钢条的价格为pi(i=1,2,3….),
先给我们一段长度为n的钢条，问怎么切割，获得的收益最大? 
*/

using System;
namespace DynamicProgramming
{
    public class SteelCuttingProblem
    {
        //方法1: 求长度为 n 的最大收益(递归从上到下)
        public int TopDown(int n, int[] price)
        {
            if (n == 0) return 0;
            int tempMaxPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                int maxPrice = price[i] + TopDown(n - i, price);
                if (maxPrice > tempMaxPrice)
                {
                    tempMaxPrice = maxPrice;
                }
            }
            return tempMaxPrice;
        }

        //方法2: 求长度为 n 的最大收益 (递归从上到下带备忘录为了更好的性能)
        public int TopDown(int n, int[] price, int[] result)
        {
            if (n == 0) return 0;
            if (result[n] != 0)
            {
                return result[n];
            }
            int tempMaxPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                int maxPrice = price[i] + TopDown(n - i, price, result);
                if (maxPrice > tempMaxPrice)
                {
                    tempMaxPrice = maxPrice;
                }
            }
            result[n] = tempMaxPrice;
            return tempMaxPrice;
        }

        //方法3: 求长度为 n 的最大收益 (由下到上, 性能最好)
        public int BottomUp(int n, int[] price, int[] result)
        {
            for (int i = 1; i <= n; i++)
            {
                int tempMaxPrice = 0;
                for (int j = 1; j <= i; j++)
                {
                    int maxPrice = price[j] + result[i - j];
                    if (maxPrice > tempMaxPrice)
                    {
                        tempMaxPrice = maxPrice;
                    }
                }
                result[i] = tempMaxPrice;
            }
            return result[n];
        }
    }
}
