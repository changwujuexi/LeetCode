using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1
{
	public class Node
	{
		public int val;
		public Node prev;
		public Node next;
		public Node child;

		public Node() { }
		public Node(int _val, Node _prev, Node _next, Node _child)
		{
			val = _val;
			prev = _prev;
			next = _next;
			child = _child;
		}
	}

		class FlattenAMultilevelDoublyLinkedList_430
	{
		//您将获得一个双向链表，除了下一个和前一个指针之外，它还有一个子指针，可能指向单独的双向链表。
		//这些子列表可能有一个或多个自己的子项，依此类推，生成多级数据结构，如下面的示例所示。
		//扁平化列表，使所有结点出现在单级双链表中。您将获得列表第一级的头部。
		//输入:
		// 1---2---3---4---5---6--NULL
		//         |
		//         7---8---9---10--NULL
		//             |
		//             11--12--NULL

		//输出:
		//1-2-3-7-8-11-12-9-10-4-5-6-NULL

		public Node Flatten(Node head)
		{
			var stack = new Stack<Node>();
			var node = head;
			while (node != null)
			{
				var next = node.next;
				if (next != null) stack.Push(next);

				if (node.child != null)
				{
					var funnode = Flatten(node.child);
					node.child = null;
					node.next = funnode;
					funnode.prev = node;
					var cur = node;
					while (cur.next != null) cur = cur.next;

					if (stack.Count != 0)
					{
						var nextNode = stack.Pop();
						cur.next = nextNode;
						nextNode.prev = cur;
					}
				}
				node = next;
			}
			return head;
		}
		//static void Main(string[] args)
		//{
		//	Node n1 = new Node();
		//	Node n2 = new Node();
		//	Node n3 = new Node();
		//	Node n4 = new Node();
		//	Node n5 = new Node();
		//	Node n6 = new Node();
		//	Node n7 = new Node();
		//	Node n8 = new Node();
		//	Node n9 = new Node();
		//	Node n10 = new Node();
		//	Node n11 = new Node();
		//	Node n12 = new Node();
		//	n1.val = 1;
		//	n2.val = 2;
		//	n3.val = 3;
		//	n4.val = 4;
		//	n5.val = 5;
		//	n6.val = 6;
		//	n7.val = 7;
		//	n8.val = 8;
		//	n9.val = 9;
		//	n10.val = 10;
		//	n11.val = 11;
		//	n12.val = 12;
		//	n1.next = n2;
		//	n2.prev = n1;
		//	n2.next = n3;
		//	n3.next = n4;
		//	n4.next = n5;
		//	n5.next = n6;
		//	n3.prev = n2;n4.prev = n3;n5.prev = n4;n6.prev = n5;
		//	n3.child = n7;n8.child = n11;
		//	n7.next = n8;n8.next = n9;n9.next = n10;
		//	n8.prev = n7;n9.prev = n8;n10.prev = n9;
		//	n11.next = n12;n12.prev = n11;
		//	var sda = new FlattenAMultilevelDoublyLinkedList_430();
		//	sda.Flatten(n1);
		//}

	}
}
