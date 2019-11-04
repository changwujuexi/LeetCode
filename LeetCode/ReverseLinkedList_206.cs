using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ReverseLinkedList_206
	{
		public class ListNode
		{
			public int val;
			public ListNode next;
			public ListNode(int x) { val = x; }
		}

		public ListNode ReverseList(ListNode head)
		{
			var thead1 = new ListNode(0);
			var thead2 = new ListNode(0);
			var thead3 = new ListNode(0);

			if (head == null) return head;
			if (head.next == null) return head;
			thead2.next = head;
			thead1.next = null;
			while (thead2.next != null)
			{
				thead3.next = thead2.next.next;
				thead2.next.next = thead1.next;
				thead1.next = thead2.next;
				thead2.next = thead3.next;
			}
			return thead1.next;
		}

		//static void Main(string[] args)
		//{
		//	var v = new ReverseLinkedList_206();
		//	var head = new ListNode(1);
		//	var n1 = new ListNode(2);
		//	var n2 = new ListNode(3);
		//	var n3 = new ListNode(4);
		//	var n4 = new ListNode(5);
		//	head.next = n1;
		//	n1.next = n2;
		//	n2.next = n3;
		//	n3.next = n4;
		//	Console.WriteLine(v.ReverseList(head));
		//	Console.ReadKey();
		//}
	}
}
