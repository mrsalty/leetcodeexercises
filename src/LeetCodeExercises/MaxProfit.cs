using System;
using System.Collections.Generic;

namespace LeetCodeExercises
{
    public class MaxProfit
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                var maxProfix = 0;

                var sorted = new int[prices.Length];
                Array.Copy(prices, sorted, prices.Length);
                Array.Sort(sorted);

                for (int i = sorted.Length - 1; i >= 0; i--) //start from highest to lowest
                {
                    var originalPositionI = GetOriginalPosition(prices, sorted[i]);
                    for (int j = 0; j < i; j++) //from 0 to current highest - 1
                    {
                        var originalPositionJ = GetOriginalPosition(prices, sorted[j]);

                        if (originalPositionI > originalPositionJ)
                        {
                            if (sorted[i] - sorted[j] > maxProfix)
                                maxProfix = sorted[i] - sorted[j];
                        }
                    }
                }

                return maxProfix;
            }

            private int GetOriginalPosition(int[] arr, int val)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == val)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }
    }
}
