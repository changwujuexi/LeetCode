using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
	class InsertIntoABinarySearchTree
	{
		public TreeNode InsertIntoBST(TreeNode root, int val)
		{
			if (root.val > val)
			{
				if (root.left == null) root.left = new TreeNode(val);
				InsertIntoBST(root.left, val);
				return root;
			}
			else if (root.val < val)
			{
				if (root.right == null) root.right = new TreeNode(val);
				InsertIntoBST(root.right, val);
				return root;
			}
			return root;
		}
	}
}
