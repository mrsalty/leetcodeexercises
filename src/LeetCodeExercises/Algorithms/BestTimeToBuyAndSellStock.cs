﻿using System;

namespace LeetCodeExercises.Algorithms
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
                if (prices.Length == 0) return 0;
                int minPrice = prices[0];
                int maxProfit = 0;
                for (int i = 0; i < prices.Length - 1; i++)
                {
                    minPrice = Math.Min(minPrice, Math.Min(prices[i], prices[i + 1]));
                    maxProfit = Math.Max(maxProfit, prices[i + 1] - minPrice);
                }

                return maxProfit;
            }
        }
    }
}
