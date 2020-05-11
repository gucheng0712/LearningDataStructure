using System;
using System.Collections;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //  SteelCutting();
            //  KnapsackProblem();
            string strs = "tact   coa";
            Console.WriteLine(IsPalindromePemutation(strs));
        }

        public static bool IsPalindromePemutation(string str)
        {
            int[] table = new int['z' - 'a' + 1];
            int oddCount = 0;

            foreach (char c in str)
            {
                int x = c;
                if (x != -1)
                {
                    table[x]++;
                    if (table[x] % 2 == 1)
                    {
                        oddCount++;
                    }
                    else
                    {
                        oddCount--;
                    }
                }
            }
            return oddCount <= 1;
        }

        private static void KnapsackProblem()
        {
            KnapsackProblem knapsack = new KnapsackProblem();
            int[] weights = { 0, 3, 4, 5 };
            int[] prices = { 0, 4, 5, 6 };
            int[,] result = new int[11, 4];
            Console.WriteLine(knapsack.BruteForceMethod(10, weights, prices));
            Console.WriteLine(knapsack.TopDownMethod(10, 3, weights, prices));
            Console.WriteLine(knapsack.OptimizedsTopDownMethod(10, 3, weights, prices, result));
            Console.WriteLine(knapsack.BottomUp(10, 3, weights, prices, result));

            Console.WriteLine(knapsack.BruteForceMethod(3, weights, prices));
            Console.WriteLine(knapsack.TopDownMethod(3, 3, weights, prices));
            Console.WriteLine(knapsack.OptimizedsTopDownMethod(3, 3, weights, prices, result));
            Console.WriteLine(knapsack.BottomUp(3, 3, weights, prices, result));
        }

        public static void SteelCutting()
        {
            //index代表钢条的长度, value代表钢条的价格
            int[] prices = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };

            SteelCuttingProblem steelCuttingProblem = new SteelCuttingProblem();

            //Console.WriteLine(steelCuttingProblem.TopDown(1, prices));
            //Console.WriteLine(steelCuttingProblem.TopDown(2, prices));
            //Console.WriteLine(steelCuttingProblem.TopDown(3, prices));
            //Console.WriteLine(steelCuttingProblem.TopDown(4, prices));
            //Console.WriteLine(steelCuttingProblem.TopDown(5, prices));

            //Console.WriteLine(steelCuttingProblem.TopDown(1, prices, new int[11]));
            //Console.WriteLine(steelCuttingProblem.TopDown(2, prices, new int[11]));
            //Console.WriteLine(steelCuttingProblem.TopDown(3, prices, new int[11]));
            //Console.WriteLine(steelCuttingProblem.TopDown(4, prices, new int[11]));
            //Console.WriteLine(steelCuttingProblem.TopDown(5, prices, new int[11]));

            Console.WriteLine(steelCuttingProblem.BottomUp(1, prices, new int[11]));
            Console.WriteLine(steelCuttingProblem.BottomUp(2, prices, new int[11]));
            Console.WriteLine(steelCuttingProblem.BottomUp(3, prices, new int[11]));
            Console.WriteLine(steelCuttingProblem.BottomUp(4, prices, new int[11]));
            Console.WriteLine(steelCuttingProblem.BottomUp(5, prices, new int[11]));
        }
    }
}
