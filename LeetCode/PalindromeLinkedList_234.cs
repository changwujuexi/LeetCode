using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class PalindromeLinkedList_234
	{
		//请判断一个链表是否为回文链表。
		public bool IsPalindrome(ListNode head)
		{
			if (head == null) return true;
			if (head.next == null) return true;

			var fast = head.next;
			var slow = head;
			ListNode pre = null;
			ListNode next = null;

			while (fast != null && fast.next != null)
			{
				pre = slow;
				fast = fast.next.next;
				slow = slow.next;

				pre.next = next;
				next = pre;
			}
			ListNode p2 = slow.next;
			slow.next = pre;
			ListNode p1 = fast == null ? slow.next : slow;
			while (p1 != null)
			{
				if (p1.val != p2.val) return false;
				p1 = p1.next;
				p2 = p2.next;
			}
			return true;

		}
	}
}
