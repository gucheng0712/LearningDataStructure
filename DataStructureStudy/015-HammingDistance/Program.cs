/*
The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
Given two integers x and y, calculate the Hamming distance.

Note:
    0 ≤ x, y < 231.

Example:

    Input: x = 1, y = 4
    Output: 2
    Explanation:
        1   (0 0 0 1)
        4   (0 1 0 0)
               ↑   ↑
               
The above arrows point to positions where the corresponding bits are different.
*/
using System;
namespace HammingDistance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HammingDistance(1, 4));
        }

        public static int HammingDistance(int x, int y)
        {
            if ((x ^ y) == 0) return 0;
            //Console.WriteLine((x ^ y) % 2);
            return (x ^ y) % 2 + HammingDistance(x / 2, y / 2);
        }
    }
}
