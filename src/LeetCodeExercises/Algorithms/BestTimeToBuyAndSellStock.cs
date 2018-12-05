using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// Say you have an array for which the ith element is the price of a given stock on day i.
    /// If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
    /// Note that you cannot sell a stock before you buy one.
    /// </summary>
    public class BestTimeToBuyAndSellStock
    {
        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                var maxCurrent = 0;
                var max = 0;
                for (var i = 1; i < prices.Length; i++)
                {
                    maxCurrent = Math.Max(0, maxCurrent + (prices[i] - prices[i - 1]));
                    max = Math.Max(maxCurrent, max);
                }
                return max;
            }
        }
    }
}
