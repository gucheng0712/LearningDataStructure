using System;
using System.Collections.Generic;
using System.Text;
namespace UniqueMorseCodeWords
{
    public class UniqueMorseCodeWords
    {
        /// <summary>
        ///  HashSet 的一些特性如下:
        ///     1. HashSet 中的值不能重复且没有顺序。
        ///     2. HashSet 的容量会按需自动添加。
        /// </summary>
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] MORSE = {".-","-...","-.-.","-..",".","..-.","--.",
                         "....","..",".---","-.-",".-..","--","-.",
                         "---",".--.","--.-",".-.","...","-","..-",
                         "...-",".--","-..-","-.--","--.."
                             };
            string str = "sagavagaf";

            HashSet<string> seen = new HashSet<string>();
            foreach (string word in words)
            {
                StringBuilder code = new StringBuilder();
                foreach (char c in word)
                {
                    code.Append(MORSE[c - 'a']);
                }
                seen.Add(code.ToString());
            }
            // Because HashSet will not add the duplicate element into the list,
            // so the count is the count of morse words
            return seen.Count;
        }
    }
}
