using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeExercises.Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/meeting-rooms-ii/
    /// Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), find the minimum number of conference rooms required.
    /// </summary>
    public class MeetingRoomsIi
    {
        public class Solution
        {
            public int MinMeetingRooms(Algorithms.Interval[] intervals)
            {
                var starts = new int[intervals.Length];
                var ends = new int[intervals.Length];

                for (int i = 0; i < intervals.Length; i++)
                {
                    starts[i] = intervals[i].start;
                    ends[i] = intervals[i].end;
                }

                Array.Sort(starts);
                Array.Sort(ends);

                var rooms = 0;
                var endsIndex = 0;
                for (int i = 0; i < starts.Length; i++)
                {
                    if (starts[i] < ends[endsIndex])
                        rooms++;
                    else
                        endsIndex++;
                }

                return rooms;
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
