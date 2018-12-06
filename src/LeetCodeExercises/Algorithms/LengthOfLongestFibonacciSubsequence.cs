using System;
using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
{
    public class LengthOfLongestFibonacciSubsequence
    {
        public class Solution
        {
            public int LenLongestFibSubseq(int[] A)
            {
                int longest = 0;
                int iterations = 0;
                var fibItems = new Dictionary<int, List<Tuple<int, int>>>();
                for (int i = A.Length - 1; i >= 2; i--)
                {
                    for (int j = i - 1; j > 0 && A[j] >= A[i] / 2; j--)
                    {
                        for (int k = 0; k < j; k++)
                        {
                            if (A[i] == A[j] + A[k])
                            {
                                iterations++;
                                if (!fibItems.ContainsKey(A[i]))
                                {
                                    fibItems.Add(A[i], new List<Tuple<int, int>>
                                    {
                                        new Tuple<int, int>(A[j], A[k])
                                    });
                                }
                                else
                                {
                                    fibItems[A[i]].Add(new Tuple<int, int>(A[j], A[k]));
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < fibItems.Count; i++)
                {
                    var current = fibItems[i];
                    while (current != null)
                    {

                    }
                }

                return longest;
            }
        }
    }
}
