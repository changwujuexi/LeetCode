using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode102
    {
        IList<IList<int>> levels = new List<IList<int>>();

        public void helper(TreeNode node,int level)
        {
            if (levels.Count == level)
                levels.Add(new List<int>());

            levels[level].Add(node.val);

            if (node.left != null)
                helper(node.left, level + 1);
            if (node.right != null)
                helper(node.right, level + 1);

        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null) return levels;
            helper(root, 0);
            return levels;
        }



    }
}
