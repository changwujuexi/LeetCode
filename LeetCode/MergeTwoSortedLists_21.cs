using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MergeTwoSortedLists_21
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		//将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
		public ListNode MergeTwoLists(ListNode l1, ListNode l2)
		{
			if (l1 == null) return l2;
			if (l2 == null) return l1;
			var n1 = l1;
			var n2 = l2;
			while (n1 != null && n2 != null)
			{
				if (n1.val <= n2.val)
				{
					var p1 = n1;
					while (p1.next != null) 
					{
						if (p1.next.val > n2.val) break;
						p1 = p1.next;
					}
					n1 = p1.next;
					p1.next = n2;
				}
				else if (n1.val > n2.val)
				{
					var p2 = n2;
					while (p2.next != null)
					{
						if (p2.next.val > n1.val) break;
						p2 = p2.next;
					}
					n2 = p2.next;
					p2.next = n1;
				}
			}
			return l1.val <= l2.val ? l1 : l2;
		}

		//static void Main(string[] args)
		//{
		//	MergeTwoSortedLists_21 a = new MergeTwoSortedLists_21();
		//	ListNode l1 = new ListNode(1);
		//	ListNode l2 = new ListNode(1);
		//	ListNode l11 = new ListNode(2);
		//	ListNode l21 = new ListNode(3);
		//	ListNode l12 = new ListNode(4);
		//	ListNode l22 = new ListNode(4);
		//	l1.next = l11;
		//	l11.next = l12;
		//	l2.next = l21;
		//	l21.next = l22;
		//	a.MergeTwoLists(l1, l2);
		//}
	}
}
