using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	//删除链表中等于给定值 val 的所有节点。
	class RemoveLinkedListElements_203
	{
		public ListNode RemoveElements(ListNode head, int val)
		{
			if (head == null) return head;
			head.next = RemoveElements(head.next, val);
			return head.val == val ? head.next : head;
		}
	}
}
