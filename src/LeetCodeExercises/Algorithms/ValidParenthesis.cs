using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercises.Algorithms
{
    public class ValidParenthesis
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
                var stack = new Stack<char>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                        continue;

                    if (s[i] == '{')
                        stack.Push('}');
                    else if (s[i] == '[')
                        stack.Push(']');
                    else if (s[i] == '(')
                        stack.Push(')');
                    else
                    {
                        if (stack.Count == 0) return false;
                        if (s[i] != stack.Pop())
                        {
                            return false;
                        }
                    }
                }
                return stack.Count == 0;
            }
        }
    }
}
