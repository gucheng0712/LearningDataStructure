using System;
namespace ChangeProblem
{
    public class GreedyMethod
    {
        public int[] Change(int moneyToChange, int[] count, int[] amount)
        {
            if (moneyToChange == 0) return new int[amount.Length + 1];

            int index = amount.Length - 1;
            int[] result = new int[amount.Length + 1];

            // 如果有
            while (true)
            {
                if (moneyToChange <= 0 || index < 0) break;
                if (moneyToChange >= count[index] * amount[index])
                {
                    result[index] = count[index];
                    moneyToChange -= count[index] * amount[index];
                }
                else
                {
                    result[index] = moneyToChange / amount[index];
                    moneyToChange -= result[index] * amount[index];
                }
                index--;
            }
            result[amount.Length] = moneyToChange;
            Console.WriteLine(moneyToChange);
            return result;
        }
    }
}
