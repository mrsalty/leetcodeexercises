using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
{
    public class LetterCombinations
    {
        public class Solution
        {
            private readonly Dictionary<char, char[]> _padMap = new Dictionary<char, char[]>()
            {
                {'2', new[] {'a', 'b', 'c'}},
                {'3', new[] {'d', 'e', 'f'}},
                {'4', new[] {'g', 'h', 'i'}},
                {'5', new[] {'j', 'h', 'l'}},
                {'6', new[] {'m', 'n', 'o'}},
                {'7', new[] {'p', 'q', 'r', 's'}},
                {'8', new[] {'t', 'u', 'v'}},
                {'9', new[] {'w', 'x', 'y', 'z'}}
            };

            public IList<string> LetterCombinations(string digits)
            {
                var result = new List<string>();

                if (string.IsNullOrEmpty(digits))
                {
                    return result;
                }

                GetLetterCombination(result, digits, "", 0);
                return result;
            }

            private void GetLetterCombination(List<string> result, string digits, string current, int index)
            {
                if (index == digits.Length)
                {
                    result.Add(current);
                    return;
                }

                char[] mapped;

                if (_padMap.ContainsKey(digits[index]))
                    mapped = _padMap[digits[index]];
                else return;


                foreach (var item in mapped)
                {
                    GetLetterCombination(result, digits, current + item, index + 1);
                }
            }
        }
    }
}
