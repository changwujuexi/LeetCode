using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class OddEvenLinkedList_328
	{
		//给定一个单链表，把所有的奇数节点和偶数节点分别排在一起。
		//请注意，这里的奇数节点和偶数节点指的是节点编号的奇偶性，而不是节点的值的奇偶性。
		//请尝试使用原地算法完成。你的算法的空间复杂度应为 O(1)，时间复杂度应为 O(nodes)，nodes 为节点总数。
		public ListNode OddEvenList(ListNode head)
		{
			if (head == null) return head;
			var nodeA = head;
			if (head.next == null) return head;
			var nodeB = head.next;
			var nodeO = head.next;
			if (nodeB.next == null) return head;
			var nodeC = nodeB.next;

			int oe = 0;

			while (true)
			{
				nodeA.next = nodeC;
				if (nodeC.next != null) nodeA = nodeC.next;
				else
				{
					if (oe % 2 == 0)
					{
						nodeC.next = nodeO;
						nodeB.next = null;
					}
					else nodeB.next = nodeO;
					return head;
				}
				nodeB.next = nodeA;
				if (nodeA.next != null) nodeB = nodeA.next;
				else
				{
					if (oe % 2 == 0) nodeC.next = nodeO;
					else
					{
						nodeA.next = nodeO;
						nodeC.next = null;
					}
					return head;
				}
				nodeC.next = nodeB;
				if (nodeB.next != null) nodeC = nodeB.next;
				else
				{
					if (oe % 2 == 0)
					{
						nodeB.next = nodeO;
						nodeA.next = null;
					}
					else nodeA.next = nodeO;
					return head;
				}

				oe += 1;
			}
		}
	}
}
