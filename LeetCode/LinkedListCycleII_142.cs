using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

	class LinkedListCycleII_142
	{
		//给定一个链表，返回链表开始入环的第一个节点。 如果链表无环，则返回 null。

		//为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

		//说明：不允许修改给定的链表
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
		public ListNode DetectCycle(ListNode head)
		{
			HashSet<ListNode> visited = new HashSet<ListNode>();

			ListNode node = head;
			while (node != null)
			{
				if (visited.Contains(node)) return node;
				visited.Add(node);
				node = node.next;
			}

			return null;
		}
	}
}
