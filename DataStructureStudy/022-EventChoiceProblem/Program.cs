using System;
using System.Collections.Generic;
using System.Linq;

/*
There are some events need to use a room at the same day, the room can only host one event every time.
Each event has a start time s[i] and a end time e[i] (i represent the index of the event).
Once the event has been chose, the event will occupy the time range from s[i] to e[i].
The other events are able to occupy the other free time which is not occpuied by a event.

This problem is to arrange the events to get the maximum compatible subset of activities.
*/

namespace EventChoiceProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // DynamicProgrammingMethod();

            List<int> l = new GreedyMethod().MaxCompatiableActivity_Recursion(1, 11, 0, 24);

            new GreedyMethod().MaxCompatiableActivity(11, 0, 24);

        }

        static void DynamicProgrammingMethod()
        {
            // 在 首部加上0 尾部加上 24 表示 最大区间 并无作用 总活动数为11
            int[] startTimes = { 0, 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12, 24 };
            int[] endTimes = { 0, 9, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 24 };
            new DynamicProgrammingProblem().MaxCompatiableActivity(startTimes, endTimes, 11);

        }



    }
}
