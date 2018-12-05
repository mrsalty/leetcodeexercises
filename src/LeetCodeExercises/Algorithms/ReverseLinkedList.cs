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
                var stack = new Stack<int>();
                var currentNode = head;
                if (head == null) return null;
                while (true)
                {
                    stack.Push(currentNode.val);
                    currentNode = currentNode.next;
                    if (currentNode == null) break;
                }

                int poppedVal;
                currentNode = null;
                ListNode poppedNode = null;
                ListNode peek = null;
                while (stack.Count > 0)
                {
                    poppedVal = stack.Pop();
                    poppedNode = new ListNode(poppedVal);
                    if (currentNode != null)
                    {
                        currentNode.next = poppedNode;
                    }
                    else
                    {
                        peek = poppedNode;
                    }

                    currentNode = poppedNode;
                }

                return peek;
            }
        }
    }
}