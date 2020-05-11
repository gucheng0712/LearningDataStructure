using System;

namespace FindLargestSubArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //ViolentMethod vm = new ViolentMethod();
            //vm.FindLargestSubArray(13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7);


            DivideConquer dc = new DivideConquer();

            int[] arr = { 13, -3, -25, 20, -3, -16, -23, 18, 20, -7, 12, -5, -22, 15, -4, 7 };
            dc.FindLargestSubArray(0, arr.Length, arr);

        }
    }
}
