using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	//根据一棵树的前序遍历与中序遍历构造二叉树。

	//注意:
	//你可以假设树中没有重复的元素。

	//例如，给出

	//前序遍历 preorder = [3,9,20,15,7]
	//	中序遍历 inorder = [9, 3, 15, 20, 7]
	//返回如下的二叉树：

	//    3
	//   / \
	//  9  20
	//    /  \
	//   15   7
	class ConstructBinaryTreeFromPreorderAndInorderTraversal_105
	{
		Hashtable table = new Hashtable();
		int pindex = 0;

		public TreeNode BuildTree(int[] preorder, int[] inorder)
		{
			for (int i = 0; i < inorder.Length; i++) table.Add(inorder[i], i);
			return Build(preorder, 0, inorder.Length - 1);
		}

		public TreeNode Build(int[] preorder,int left,int right)
		{
			if (left > right) return null;
			TreeNode node = new TreeNode(preorder[pindex++]);
			int index = (int)table[node.val];
			
			node.left = Build(preorder, left, index - 1);
			node.right = Build(preorder, index + 1, right);
			return node;
		}

		static void Main(string[] args)
		{
			var dsda = new ConstructBinaryTreeFromPreorderAndInorderTraversal_105();
			dsda.BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 });
		}
	}
}
