using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	//根据一棵树的中序遍历与后序遍历构造二叉树。

	//注意:
	//你可以假设树中没有重复的元素。

	//例如，给出

	//中序遍历 inorder = [9,3,15,20,7]
	//	后序遍历 postorder = [9, 15, 7, 20, 3]
	//返回如下的二叉树：

	  //  3
	  // / \
	  //9  20
	  //  /  \
	  // 15   7

	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	class ConstructBinaryTreeFromInorderAndPostorderTraversal_106
	{

		Hashtable table = new Hashtable();
		int pindex = 0;

		public TreeNode BuildTree(int[] inorder, int[] postorder)
		{
			pindex = postorder.Length - 1;
			for (int i = 0; i < inorder.Length; i++) table.Add(inorder[i], i);
			return Build(postorder, 0, inorder.Length - 1);
		}

		public TreeNode Build(int[] postorder,int left,int right)
		{
			if (left > right) return null;
			TreeNode node = new TreeNode(postorder[pindex--]);
			int index = (int)table[node.val];
			node.right = Build(postorder, index + 1, right);
			node.left = Build(postorder, left, index - 1);
			return node;
		}

	}
}
