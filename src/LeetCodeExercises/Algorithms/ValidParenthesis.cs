using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
{
    public class ValidParenthesis
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
                var stack = new Stack<char>();
                foreach (char c in s)
                {
                    if (c == ' ') continue;
                    if (c == '(')
                        stack.Push(')');
                    else if (c == '{')
                        stack.Push('}');
                    else if (c == '[')
                        stack.Push(']');
                    else
                    {
                        if (stack.Count == 0) return false;
                        var match = stack.Pop() == c;
                        if (!match) return false;
                    }
                }

                return stack.Count == 0;
            }
        }
    }
}
