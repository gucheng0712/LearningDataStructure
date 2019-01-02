using System;
namespace DynamicProgramming
{
    public class KnapsackProblem
    {

        // 方法1: 暴力求解
        public int BruteForceMethod(int capacity, int[] weights, int[] prices)
        {
            int maxPrice = 0;
            for (int i = 0; i < Math.Pow(2, capacity); i++)
            {
                int weightTotal = 0;
                int priceTotal = 0;

                for (int num = 1; num < weights.Length; num++)
                {
                    int res = GetBit(i, num);
                    if (res == 1)
                    {
                        weightTotal += weights[num];
                        priceTotal += prices[num];
                    }
                }

                if (weightTotal <= capacity && priceTotal > maxPrice)
                {
                    maxPrice = priceTotal;
                }
            }
            return maxPrice;
        }

        //取得 i 上第 num 位上的二进制值,是 1 还是 0
        public static int GetBit(int i, int num)
        {
            int A = i;
            int B = (int)Math.Pow(2, num - 1);

            int result = A & B;

            return (result == 0) ? 0 : 1;
        }


        // 方法2: 动态规划 (自顶向下)
        // capacity: 背包容量
        // i: 物品个数, 也只索引
        // weights: 各个物品所占用的空间
        // prices: 各个物品的价值
        public int TopDownMethod(int capacity, int i, int[] weights, int[] prices)
        {
            if (i == 0 || capacity == 0) return 0;

            // 如果当前索引的物品重量大于背包的容量, 那么就递归前一个索引
            if (weights[i] > capacity)
            {
                return TopDownMethod(capacity, i - 1, weights, prices);
            }
            else
            {
                //价格的累积递归
                int maxVal1 = TopDownMethod(capacity - weights[i], i - 1, weights, prices) + prices[i];

                //前一个索引的价格的累积递归
                int maxVal2 = TopDownMethod(capacity, i - 1, weights, prices);

                // 比较返回较大的数
                return maxVal1 > maxVal2 ? maxVal1 : maxVal2;
            }
        }

        // 方法3: 带备忘录的动态规划 (自顶向下)
        public int OptimizedsTopDownMethod(int capacity, int i, int[] weights, int[] prices, int[,] result)
        {
            if (i == 0 || capacity == 0) return 0;

            // 当在索引的价格不为0 那么表示当前价格已经计算出来了,直接返回这个价格
            if (result[capacity, i] != 0)
            {
                return result[capacity, i];
            }

            // 如果当前索引的物品重量大于背包的容量, 那么就递归前一个索引
            if (weights[i] > capacity)
            {
                result[capacity, i] = TopDownMethod(capacity, i - 1, weights, prices);
                return result[capacity, i];
            }
            else
            {
                //价格的累积递归
                int maxVal1 = TopDownMethod(capacity - weights[i], i - 1, weights, prices) + prices[i];

                //前一个索引的价格的累积递归
                int maxVal2 = TopDownMethod(capacity, i - 1, weights, prices);

                // 比较返回较大的数
                result[capacity, i] = maxVal1 > maxVal2 ? maxVal1 : maxVal2;
                return result[capacity, i];
            }
        }

        // 方法4: 动态规划(自底向上)
        public int BottomUp(int capacity, int i, int[] weights, int[] prices, int[,] result)
        {
            if (result[capacity, i] != 0) return result[capacity, i];
            for (int tempCapacity = 1; tempCapacity <= capacity; tempCapacity++)
            {
                for (int tempI = 1; tempI <= i; tempI++)
                {
                    if (result[tempCapacity, tempI] != 0) continue;
                    if (weights[tempI] > tempCapacity) // 如果背包容量不够,那么就等于上一个
                    {
                        result[tempCapacity, tempI] = result[tempCapacity, tempI - 1];
                    }
                    else
                    {
                        int maxVal1 = result[tempCapacity - weights[tempI], tempI - 1] + prices[tempI];
                        int maxVal2 = result[tempCapacity, tempI - 1];

                        result[tempCapacity, tempI] = (maxVal1 > maxVal2) ? maxVal1 : maxVal2;
                    }
                }
            }
            return result[capacity, i];
        }

    }

}
