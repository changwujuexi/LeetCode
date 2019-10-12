using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_83
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }


        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            var pointer = head;
            while (pointer.next != null)
            {
                while (pointer.val == pointer.next.val)
                {
                    pointer.next = pointer.next.next;
                    if (pointer.next == null) return head;
                }
                pointer = pointer.next;
            }
            return head;
        }
    }
}
