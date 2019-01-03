using System;

namespace ChangeProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] count = { 3, 0, 2, 1, 0, 3, 5 };
            int[] amount = { 1, 2, 5, 10, 20, 50, 100 };

            int[] result = new GreedyMethod().Change(320, count, amount);
            foreach (var i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}
