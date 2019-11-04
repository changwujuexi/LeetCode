using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class SwapNodesInPairs
	{
		//		给定一个链表，两两交换其中相邻的节点，并返回交换后的链表。

		//你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode SwapPairs(ListNode head)
		{
			var thead = new ListNode(0);
			thead.next = head;
			var start = thead;
			while (thead.next != null && thead.next.next != null)
			{
				var a = thead.next;
				var b = thead.next.next;
				thead.next = b;
				a.next = b.next;
				b.next = a;
				thead = a;
			}
			return start.next;
		}
	}
}
