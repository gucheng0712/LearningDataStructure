using System;
using System.Collections.Generic;

namespace _0033_ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("({[][{}][][]})"));
        }

        static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(')');
                else if (s[i] == '{')
                    stack.Push('}');
                else if (s[i] == '[')
                    stack.Push(']');
                else if (stack.Pop() != s[i])
                    return false;
            }
            return stack.Count == 0;
        }
    }
}
