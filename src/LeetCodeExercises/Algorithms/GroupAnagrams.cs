using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises.Algorithms
{
    public class GroupAnagrams
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                var ret = new List<IList<string>>();
                var added = new bool[strs.Length];
                for (int i = 0; i < strs.Length; i++)
                {
                    var list = new List<string>();
                    if (i == 0)
                    {
                        list.Add(strs[i]);
                        added[i] = true;
                        for (int j = i + 1; j < strs.Length; j++)
                        {
                            if (IsAnagram(strs[i], strs[j]))
                            {
                                list.Add(strs[j]);
                                added[j] = true;
                            }
                        }
                    }
                    else
                    {
                        if (!added[i])
                        {
                            for (int j = i + 1; j <= strs.Length; j++)
                            {
                                if (j < strs.Length)
                                {
                                    if (IsAnagram(strs[i], strs[j]))
                                    {
                                        list.Add(strs[j]);
                                        added[j] = true;
                                    }
                                }
                                else
                                {
                                    list.Add(strs[i]);
                                }
                            }
                        }
                    }

                    if (list.Count > 0)
                        ret.Add(list.ToList());
                }

                return ret;
            }

            private bool IsAnagram(string src, string dest)
            {
                if (string.IsNullOrEmpty(src) && string.IsNullOrEmpty(dest)) return true;
                if (src.Length != dest.Length) return false;

                for (var i = 0; i < src.Length; i++)
                {
                    var indexOf = dest.IndexOf(src[i]);
                    if (indexOf < 0) return false;
                    dest = dest.Remove(indexOf, 1);
                }

                return true;
            }
        }
    }
}
