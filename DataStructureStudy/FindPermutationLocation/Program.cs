/*
Questions: 
    Given a smaller string s and a bigger string b, 
    design an algorithm to find all permutations of the shorter string within the longer one. 
    Print the location of each permutation.

Extraordinarily slow algorithm: Generate all permutations of s and then look for each in b. 
Since there are S! permutations, this will take O(S! * B) time, where S is the length of s and B is the length of b.

Give yourself a big example, like this one: 
    s: abbc 
    b: cbabadcbbabbcbabaabccbabc 
    Where are the permutations of s within b?

Almost everyone takes one of two approaches: 
    1. Walk through b and look at sliding windows of 4 characters(s.length = 4). Check if each window is a permutation of s.
    2. Walk through b. Every time you see a character in s, check if the next 4 characters are a permutation of s.

Depending on the implementation of the “is this a permutation” part, 
you’ll probably get a runtime of either O(B * S), O(B * Slog S), 
or O(B * S2). None of these are the most optimal algorithm(there is an O(B) algorithm: Use prime number multiple?).

Try this approach when you’re solving questions. 
Use a nice, big example and manually solve it for the specific example. 
Then, think hard about how you solved it. Reverse engineer your own approach.

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindPermutationLocation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "abbc";
            string b = "cbabadcbbabbcbabaabccbabc";

            List<int> locations = new List<int>();
            char[] sArray = s.ToCharArray();
            int equalCount = 0;
            for (int i = 0; i <= b.Length - s.Length; i++)
            {
                List<char> list = sArray.ToList();
                for (int j = i; j < i + s.Length; j++)
                {
                    if (list.Contains(b[j]))
                    {
                        list.Remove(b[j]);
                        equalCount++;
                    }
                }
                if (equalCount == s.Length)
                {
                    locations.Add(i);

                }
                equalCount = 0;
            }

            foreach (var l in locations)
                Console.WriteLine(l);

        }
    }
}
