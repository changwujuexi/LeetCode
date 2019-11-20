using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
	class DeleteNodeInABST
	{
		public TreeNode DeleteNode(TreeNode root, int key)
		{
			if (root == null) return null;

			if (key < root.val)
			{
				root.left = DeleteNode(root.left, key);
				return root;
			}
			else if (key > root.val)
			{
				root.right = DeleteNode(root.right, key);
				return root;
			}
			else
			{
				if (root.left == null) return root.right;
				else if (root.right == null) return root.left;
				else
				{
					var minRight = root.right;
					while (minRight.left != null) minRight.left = minRight.left;
					
					minRight = root.left;
					return root.right;

				}
			}
		}

		
	}
}
