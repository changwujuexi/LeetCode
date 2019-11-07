using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class RemoveNthNodeFromEndOfList_19
	{
		//给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			if (head == null) return head;
			ListNode node = head;
			ListNode pre = head;
			ListNode prep = head;
			int i = 0;
			while (i < n - 1)
			{
				node = node.next;
				i++;
			}
			if (node.next == null) return head.next;
			node = node.next;
			pre = pre.next;
			while (node.next != null)
			{
				node = node.next;
				pre = pre.next;
				prep = prep.next;
			}
			prep.next = pre.next;
			return head;
		}
	}
}
