using System.Collections.Generic;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/word-break/
    /// </summary>
    public class WordBreak
    {
        public class Solution
        {
            public bool WordBreak(string s, ISet<string> wordDict)
            {
                int length = s.Length;

                var results = new bool[length + 1];

                results[0] = true;
                for (var i = 1; i < length + 1; i++)
                {
                    for (var j = 0; j < i; j++)
                    {
                        var substring = s.Substring(j, i - j);
                        if (results[j] && wordDict.Contains(substring))
                        {
                            results[i] = true;
                            break;
                        }
                    }
                }
                return results[length];
            }
        }
    }
}