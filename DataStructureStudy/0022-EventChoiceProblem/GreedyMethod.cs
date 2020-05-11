using System;
using System.Collections.Generic;

namespace EventChoiceProblem
{
    public class GreedyMethod
    {
        static int[] startTimes = { 0, 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };
        static int[] endTimes = { 0, 9, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public List<int> MaxCompatiableActivity_Recursion(int startActivityNum, int endActivityNum, int startTime, int endTime)
        {
            if (startActivityNum > endActivityNum || startTime >= endTime)
            {
                return new List<int>();
            }

            int tempNum = 0;
            for (int num = startActivityNum; num <= endActivityNum; num++)
            {
                if (startTimes[num] >= startTime && endTimes[num] <= endTime)
                {
                    tempNum = num;
                    break;
                }
            }

            List<int> list = MaxCompatiableActivity_Recursion(tempNum + 1, endActivityNum, endTimes[tempNum], endTime);
            list.Add(tempNum);
            Console.Write(tempNum + " ");
            return list;
        }

        public List<int> MaxCompatiableActivity_Iteration(int n, int startTime, int endTime)
        {
            List<int> list = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                if (startTimes[num] >= startTime && endTimes[num] <= endTime)
                {
                    list.Add(num);
                    startTime = endTimes[num];
                    Console.Write(num + " ");
                }
            }
            return list;
        }
    }
}
