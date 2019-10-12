using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_110
    {
        public bool IsBalanced(TreeNode root)
        {
            return depth(root) != -1;
        }

        //DFS提前阻断
        private static int depth(TreeNode root)
        {
            if (root == null) return 0;
            int left = depth(root.left);
            if (left == -1) return -1;
            int right = depth(root.right);
            if (right == -1) return -1;

            return Math.Abs(left - right) < 2 ? Math.Max(left, right) + 1 : -1;
        }
    }
}
