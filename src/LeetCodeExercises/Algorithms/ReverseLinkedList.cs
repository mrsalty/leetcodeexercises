using System.Collections.Generic;

namespace LeetCodeExercises.Algorithms
{
    public class ReverseLinkedList
    {public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                ListNode current = head;
                ListNode newListNode = null;
                ListNode tmp = null;
                while (current != null)
                {
                    newListNode = new ListNode(current.val)
                    {
                        next = tmp
                    };
                    tmp = newListNode;
                    current = current.next;
                }
                return newListNode;
            }
        }
    }
}