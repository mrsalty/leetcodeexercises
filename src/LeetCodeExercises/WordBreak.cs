using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/word-break/
    /// </summary>
    public class WordBreak
    {
        public class Solution
        {
            public bool WordBreak(string str, IList<string> wordDict)
            {
                return WordBreakRecurrent(str, str, wordDict);
            }

            public bool WordBreakRecurrent(string source, string str, IList<string> wordDict)
            {
                if (str == string.Empty) return true;

                var isWordBreak = false;
                for (var i = 0; i < wordDict.Count && !isWordBreak; i++)
                {
                    if (str.Contains(wordDict[i]))
                    {
                        var strWithoutCurrent = str;
                        while (strWithoutCurrent.IndexOf(wordDict[i]) >= 0)
                        {
                            strWithoutCurrent = strWithoutCurrent.Remove(strWithoutCurrent.IndexOf(wordDict[i]),
                                wordDict[i].Length);
                        }

                        var wordDictWithoutCurrent = new List<string>(wordDict);
                        wordDictWithoutCurrent.RemoveAt(i);
                        isWordBreak = WordBreak(strWithoutCurrent, wordDictWithoutCurrent);
                    }
                }

                return isWordBreak;
            }
        }
    }
}