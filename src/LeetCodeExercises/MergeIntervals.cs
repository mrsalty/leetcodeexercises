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
                var dest = new List<Interval>();
                var destCount = 0;

                MergeItems(intervals, dest);

                return dest;
            }

            public void MergeItems(IList<Interval> src, IList<Interval> dest)
            {
                if (src == null || src.Count == 0)
                {
                    return;
                }

                var item = src[0];
                var toList = src.ToList();
                toList.RemoveAt(0);
                src = toList.ToArray();

                bool add = false;
                if (dest.Count > 0)
                {
                    var destCount = dest.Count;
                    for (int i = 0; i < destCount; i++)
                    {
                        if (Overlap(item, dest[i]) || StartEndBothInternal(item, dest[i]))
                        {
                            //they match, ignore
                        }
                        else if (StartEndBothInternal(dest[i], item))
                        {
                            dest[i].start = item.start;
                            dest[i].end = item.end;
                        }
                        else if (StartInternal(item, dest[i]))
                        {
                            dest[i].end = item.end;
                        }
                        else if (EndInternal(item, dest[i]))
                        {
                            dest[i].start = item.start;
                        }
                        else
                        {
                            add = true;
                        }
                    }
                }
                else
                {
                    add = true;
                }

                if (add)
                {
                    dest.Add(item);
                }

                MergeItems(src, dest);
            }

            private static bool Overlap(Interval item, Interval interval)
            {
                return interval.start == item.start && interval.end == item.end;
            }

            private static bool StartEndBothInternal(Interval item, Interval interval)
            {
                return (item.start > interval.start && item.start < interval.end) &&
                       (item.end > interval.start && item.end < interval.end);
            }

            private static bool StartInternal(Interval item, Interval interval)
            {
                return (item.start >= interval.start && item.start <= interval.end) &&
                       (item.end > interval.end);
            }

            private static bool EndInternal(Interval item, Interval interval)
            {
                return (item.end >= interval.start && item.end <= interval.end) && (item.start < interval.start);
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
