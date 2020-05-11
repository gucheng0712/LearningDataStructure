using System;
using System.Diagnostics;

/// <summary>
/// 需要 n 阶 才能到达顶楼
/// 每次可以选择爬 1 或 2 个台阶, 由多少种不同的方法可以爬到楼顶
/// </summary>

namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = MethodsOnClimbingStairs(4);
            Console.WriteLine(n);

            Console.WriteLine("-----------");

            int n2 = RecursionSolution(4);
            Console.WriteLine(n2);
        }

        // Fibonacci:  f(n) = f(n-1) + f(n-2) 
        static int MethodsOnClimbingStairs(int n)
        {
            if (n <= 2)
                return n;

            int f1 = 1;
            int f2 = 2;
            int f3 = f1 + f2;
            for (int i = 3; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }

        static int RecursionSolution(int n)
        {
            if (n <= 2)
            {
                return n;
            }

            return RecursionSolution(n - 1) + RecursionSolution(n - 2);
        }
    }
}
