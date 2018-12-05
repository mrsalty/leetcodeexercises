using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/meeting-rooms-ii/
    /// </summary>
    public class MeetingRoomsIi
    {
        public class Solution
        {
            public int MinMeetingRooms(Algorithms.Interval[] intervals)
            {
                if (!intervals.Any())
                {
                    return 0;
                }

                int result = 0;
                int count = 0;
                var ends = new List<Algorithms.Interval>();

                var orderedByStart = intervals.OrderBy(x => x.start);
                foreach (var interval in orderedByStart)
                {
                    var itemWithStartMajorCurrentItemEnd = ends.FirstOrDefault(x => interval.start >= x.end);

                    if (count == 0 || itemWithStartMajorCurrentItemEnd == null) 
                    {
                        ends.Add(interval);
                        result++;
                    }
                    else
                    {
                        itemWithStartMajorCurrentItemEnd.start = interval.start;
                        itemWithStartMajorCurrentItemEnd.end = interval.end;
                    }

                    ends = ends.OrderByDescending(x => x.end).ToList();
                    count++;
                }

                return result;
            }
        }


        public class Interval
        {
            public int start;
            public int end;

            public Interval()
            {
                start = 0;
                end = 0;
            }

            public Interval(int s, int e)
            {
                start = s;
                end = e;
            }
        }
    }
}
