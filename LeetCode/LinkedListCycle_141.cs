using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class LinkedListCycle_141
	{
		//给定一个链表，判断链表中是否有环。
		//为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x)
			{
				val = x;
				next = null;
			}
		}
		public bool HasCycle(ListNode head)
		{
			if (head == null || head.next == null) return false;
			ListNode fast = head.next;
			ListNode slow = head;
			while (fast != slow)
			{
				if (fast == null || fast.next==null) return false;
				fast = fast.next.next;
				slow = slow.next;
			}
			return true;
		}
	}
}
