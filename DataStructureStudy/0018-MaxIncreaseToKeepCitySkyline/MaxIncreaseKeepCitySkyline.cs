using System;
namespace MaxIncreaseToKeepCitySkyline
{
    public class MaxIncreaseKeepCitySkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int sum = 0;
            int n = grid.Length;
            int[] colMaxes = new int[n];
            int[] rowMaxes = new int[n];

            // 得到行列最大的数
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    colMaxes[c] = Math.Max(colMaxes[c], grid[r][c]);
                    rowMaxes[r] = Math.Max(rowMaxes[r], grid[r][c]);
                }
            }

            for (int r = 0; r < n; ++r)
            {
                for (int c = 0; c < n; ++c)
                {
                    sum += Math.Min(rowMaxes[r], colMaxes[c]) - grid[r][c];
                }

            }
            return sum;
        }
    }
}
