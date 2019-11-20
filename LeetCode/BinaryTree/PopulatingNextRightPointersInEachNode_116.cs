using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class PopulatingNextRightPointersInEachNode_116
	{
		//		给定一个完美二叉树，其所有叶子节点都在同一层，每个父节点都有两个子节点。二叉树定义如下：

		//      struct Node
		//		{
		//			int val;
		//			Node* left;
		//			Node* right;
		//			Node* next;
		//		}
		//		填充它的每个 next 指针，让这个指针指向其下一个右侧节点。如果找不到下一个右侧节点，则将 next 指针设置为 NULL。

		//初始状态下，所有 next 指针都被设置为 NULL。

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

		public Node Connect(Node root)
		{
			if (root == null) return null;
			var level = root;
			var walker = root;
			while (level != null)
			{
				if (level.left == null) return root;
				walker = level;
				while (walker != null)
				{
					walker.left.next = walker.right;
					if (walker.next != null) walker.right.next = walker.next.left;
					walker = walker.next;
				}
				level = level.left;
			}
			return root;
		}
	}
}
