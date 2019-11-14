using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FindDuplicateSubtrees_652
	{
		//给定一棵二叉树，返回所有重复的子树。对于同一类的重复子树，你只需要返回其中任意一棵的根结点即可。
		//两棵树重复是指它们具有相同的结构以及相同的结点值。
		public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
		{
			List<TreeNode> set = new List<TreeNode>();
			Hashtable table = new Hashtable();

			if (root == null) return set;
			saveRoute(root, set, table);
			return set;

		}

		private string saveRoute(TreeNode node,List<TreeNode> set,Hashtable table)
		{
			if (node == null) return "";
			string str = node.val + "," + saveRoute(node.left, set, table) + "," + saveRoute(node.right, set, table);
			if (table.ContainsKey(str))
			{
				if ((int)table[str] == 1)
				{
					set.Add(node);
					table[str] = 2;
				}
			}
			else
			{
				table.Add(str, 1);
			}
			return str;
		}

		//private static void Main(string[] args)
		//{
		//	var ds = new FindDuplicateSubtrees_652();
		//	TreeNode root = new TreeNode(0);
		//	TreeNode n1 = new TreeNode(0);
		//	TreeNode n2 = new TreeNode(0);
		//	TreeNode n3 = new TreeNode(0);
		//	TreeNode n4 = new TreeNode(0);
		//	TreeNode n5 = new TreeNode(0);
		//	root.left = n1;n1.left = n2;root.right = n3;n3.right = n4;n4.right = n5;

		//	ds.FindDuplicateSubtrees(root);
		//}

	}
}
