using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	public class Node
	{
		public int val;
		public Node left;
		public Node right;
		public Node next;

		public Node() { }
		public Node(int _val, Node _left, Node _right, Node _next)
		{
			val = _val;
			left = _left;
			right = _right;
			next = _next;
		}
	}

	class PopulatingNextRightPointersInEachNodeII_117
	{
		public Node Connect(Node root)
		{
			if (root == null) return root;
			Node level = root, walker, next;
			while (level != null)
			{
				walker = FindNextNode(level);
				if (walker == null) return root;
				else level = walker.left == null ? walker.right : walker.left;
				while (walker != null)
				{
					if (walker.left != null && walker.right != null)
					{
						walker.left.next = walker.right;
						next = FindNextNode(walker.next);
						if (next != null) walker.right.next = next.left == null ? next.right : next.left;
						else break;
					}
					else
					{
						next = FindNextNode(walker.next);
						if (walker.left != null)
						{
							if (next != null) walker.left.next = next.left == null ? next.right : next.left;
							else break;
						}
						else
						{
							if (next != null) walker.right.next = next.left == null ? next.right : next.left;
							else break;
						}
					}
					walker = FindNextNode(walker.next);
				}
				
			}
			return root;
		}

		public Node FindNextNode(Node cur)
		{
			if (cur == null) return null;
			if (cur.left != null || cur.right != null) return cur;
			else if (cur.next == null) return null;
			else return FindNextNode(cur.next);
		}
	}
}
