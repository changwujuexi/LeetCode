using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class AddTwoNumbers_2
	{
		//给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序的方式存储的，并且它们的每个节点只能存储 一位数字。

		//如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			var n1 = l1;
			var n2 = l2;
			var pre = l2;
			int ad = 0;
			int temp;
			while (n1 != null && n2 != null)
			{
				int num = n1.val + n2.val + ad;
				temp = num % 10;
				n2.val = temp;
				ad = num / 10;
				n1 = n1.next;
				pre = n2;
				n2 = n2.next;
			}
			if (n1 != null && n2 == null)
			{
				while (n1 != null)
				{
					pre.next = n1;
					int num = n1.val + ad;
					temp = num % 10;
					n1.val = temp;
					ad = num / 10;
					pre = n1;
					n1 = n1.next;
				}
				
			}
			else if (n2 != null && n1 == null)
			{
				while (n2 != null)
				{
					int num = n2.val + ad;
					temp = num % 10;
					ad = num / 10;
					n2.val = temp;
					pre = n2;
					n2 = n2.next;

				}
			}
			if (ad == 1) pre.next = new ListNode(1);
			return l2;
		}

		//static void Main(string[] args)
		//{
		//	var sda = new AddTwoNumbers_2();
		//	ListNode l1 = new ListNode(8);
		//	l1.next = new ListNode(9);
		//	l1.next.next = new ListNode(9);
		//	ListNode l2 = new ListNode(2);

		//	sda.AddTwoNumbers(l1, l2);
		//}
	}
}
