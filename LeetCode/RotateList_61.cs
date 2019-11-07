using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class RotateList_61
	{
		//给定一个链表，旋转链表，将链表每个节点向右移动 k 个位置，其中 k 是非负数。
		public ListNode RotateRight(ListNode head, int k)
		{
			if (head == null) return head;
			if (k == 0) return head;
			var pre = head;
			var prepre = pre;
			var next = head;
			var prenext = pre;
			int len = int.MaxValue;
			bool ifs = false;
			for (int i = 0; i < k; i++)
			{
				if (next != null) next = next.next;
				else
				{
					len = i;
					ifs = true;
					break;
				}
			}
			if (ifs)
			{
				if (len == 1) return head;
				next = head;
				int loop = k % len;
				if (loop == 0) return head;
				for (int i = 0; i < loop; i++) next = next.next;

				while (next != null)
				{
					prepre = pre;
					pre = pre.next;
					prenext = next;
					next = next.next;
				}
				prenext.next = head;
				prepre.next = null;
			}
			else
			{
				if (next == null) return head;
				while (next != null)
				{
					prepre = pre;
					pre = pre.next;
					prenext = next;
					next = next.next;
				}
				prenext.next = head;
				prepre.next = null;
			}
			return pre;

		}

		//static void Main(string[] args)
		//{
		//	RotateList_61 ds = new RotateList_61();
		//	ListNode n1 = new ListNode(1);
		//	ListNode n2 = new ListNode(2);
		//	ListNode n3 = new ListNode(3);
		//	ListNode n4 = new ListNode(4);
		//	ListNode n5 = new ListNode(5);
		//	n1.next = n2;
		//	n2.next = n3;
		//	n3.next = n4;
		//	n4.next = n5;
		//	n5.next = null;
		//	ds.RotateRight(n1, 10);
		//}
	}
}
