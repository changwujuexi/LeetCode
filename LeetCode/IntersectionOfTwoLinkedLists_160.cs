using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	class IntersectionOfTwoLinkedLists_160
	{
		public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
		{
			if (headA == null || headB == null) return null;
			ListNode pa = headA;
			ListNode pb = headB;
			while (pa != pb)
			{
				pa = pa == null ? headB : pa.next;
				pb = pb == null ? headA : pb.next;
			}
			return pa;
		}
	}
}
