using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
	class SearchInABinarySearchTree
	{
		//给定二叉搜索树（BST）的根节点和一个值。 你需要在BST中找到节点值等于给定值的节点。 返回以该节点为根的子树。 如果节点不存在，则返回 NULL。
		public TreeNode SearchBST(TreeNode root, int val)
		{
			if (root == null) return null;
			if (root.val > val) return SearchBST(root.left, val);
			else if (root.val < val) return SearchBST(root.right, val);
			else return root;
		}
	}
}
