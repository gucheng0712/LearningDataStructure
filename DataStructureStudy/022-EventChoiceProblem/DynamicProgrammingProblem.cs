using System;
using System.Collections.Generic;
using System.Linq;

namespace EventChoiceProblem
{
    public class DynamicProgrammingProblem
    {
        public List<int> MaxCompatiableActivity(int[] s, int[] f, int n)
        {
            List<int>[][] result = new List<int>[n + 2][];
            for (int i = 0; i < n + 2; i++)
            {
                result[i] = new List<int>[n + 2];
            }

            for (int j = 0; j <= n + 1; j++)
                for (int i = 0; i <= n + 1; i++)
                    result[i][j] = new List<int>();


            for (int j = 1; j <= n + 1; j++)
            {
                for (int i = 0; i < j; i++)//i < j
                {
                    int maxTemp = 0;
                    List<int> tempList = new List<int>();
                    for (int k = i + 1; k < j; k++)// i<k<j  (if i>=j S(i,j)是空集合)
                    {
                        if (s[k] >= f[i] && f[k] <= s[j])//S(i,j)不空
                        {
                            // result[i,j] = max { result[i,k] + result[k,j] + k }
                            if (result[i][k].Count + result[k][j].Count + 1 > maxTemp)
                            {
                                maxTemp = result[i][k].Count + result[k][j].Count + 1;
                                tempList = result[i][k].Union(result[k][j]).ToList();  // result[i,k] + result[k,j]
                                tempList.Add(k); // +k
                            }

                        }
                    }//inner for
                    result[i][j] = tempList;
                }//medium for
            }//outer for
            List<int> res = result[0][n + 1];
            foreach (var temp in res)
            {
                Console.WriteLine(temp);
            }
            return res;
        }
    }
}
