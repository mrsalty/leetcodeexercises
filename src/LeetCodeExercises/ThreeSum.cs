using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises
{
    public class ThreeSum
    {
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                var results = new Dictionary<string, IList<int>>();

                Array.Sort(nums);

                var negatives = new List<int>();
                var positives = new List<int>();
                var zeroesCount = 0;
                foreach (var num in nums)
                {
                    if (num < 0)
                    {
                        negatives.Add(num);
                    }
                    else
                    {
                        if (num == 0)
                            zeroesCount++;
                        positives.Add(num);
                    }
                }

                if (zeroesCount >= 3)
                {
                    results.Add("000", new List<int>() { 0, 0, 0 });
                }

                //loop negatives
                for (int i = 0; i < negatives.Count; i++)
                {
                    //try with duplets of negatives
                    for (int j = i + 1; j < negatives.Count; j++)
                    {
                        for (int k = 0; k < positives.Count; k++)
                        {
                            if (negatives[i] + negatives[j] + positives[k] == 0)
                            {
                                if (!results.ContainsKey($"{negatives[i]}{negatives[j]}{positives[k]}"))
                                    results.Add($"{negatives[i]}{negatives[j]}{positives[k]}", new List<int>() { negatives[i], negatives[j], positives[k] });
                            }
                        }
                    }

                    //try with duplets of positives
                    for (int j = 0; j < positives.Count; j++)
                    {
                        for (int k = j + 1; k < positives.Count; k++)
                        {
                            if (negatives[i] + positives[j] + positives[k] == 0)
                            {
                                if (!results.ContainsKey($"{negatives[i]}{positives[j]}{positives[k]}"))
                                    results.Add($"{negatives[i]}{positives[j]}{positives[k]}", new List<int>() { negatives[i], positives[j], positives[k] });
                            }
                        }
                    }
                }

                return results.Values.ToList();
            }
        }
    }
}
