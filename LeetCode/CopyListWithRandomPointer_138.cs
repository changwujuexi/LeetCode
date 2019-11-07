using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2
{
	public class Node
	{
		public int val;
		public Node next;
		public Node random;

		public Node() { }
		public Node(int _val, Node _next, Node _random)
		{
			val = _val;
			next = _next;
			random = _random;
		}
	}

	class CopyListWithRandomPointer_138
	{
		//给定一个链表，每个节点包含一个额外增加的随机指针，该指针可以指向链表中的任何节点或空节点。
		//要求返回这个链表的深拷贝。
		public Node CopyRandomList(Node head)
		{
			if (head == null) return head;
			var node = head;
			while (node != null)
			{
				Node clone = new Node(node.val, node.next, null);
				Node temp = node.next;
				node.next = clone;
				node = temp;
			}

			node = head;
			while (node != null)
			{
				node.next.random = node.random == null ? null : node.random.next;
				node = node.next.next;
			}

			var newNode = new Node();
			node = head;
			var newHead = head.next;
			while (node != null)
			{
				newNode.next = node.next;
				newNode = newNode.next;
				node.next = newNode.next;
				node = node.next;
			}
			return newHead;
		}
	}
}
