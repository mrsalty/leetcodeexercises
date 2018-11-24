using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// </summary>
    public class MergeIntervals
    {
        public class Solution
        {
            public IList<Interval> Merge(IList<Interval> intervals)
            {
                var ret = new List<Interval>();
                if (intervals == null || intervals.Count == 0)
                {
                    return ret;
                }

                intervals = intervals.OrderBy(x => x.start).ToList();

                foreach (Interval interval in intervals)
                {
                    if (ret.Count == 0)
                    {
                        ret.Add(interval);
                    }
                    else
                    {
                        var last = ret[ret.Count - 1];

                        if (interval.start <= last.end)
                        {
                            if (interval.end > last.end)
                            {
                                last.end = interval.end;
                            }
                        }
                        else
                        {
                            ret.Add(interval);
                        }
                    }
                }

                return ret;
            }
        }
    }

    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
}
