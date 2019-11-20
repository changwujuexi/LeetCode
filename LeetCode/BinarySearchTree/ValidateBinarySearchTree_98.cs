using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ValidateBinarySearchTree_98
    {

        //广度遍历
        public bool helper(TreeNode root, TreeNode lower,TreeNode upper)
        {
            if (root == null) return true;

            int val = root.val;
            if (lower != null && val <= lower.val) return false;
            if (upper != null && val >= upper.val) return false;

            if (!helper(root.right, root, upper)) return false;
            if (!helper(root.left, lower, root)) return false;
            return true;
        }

        public bool IsValidBST(TreeNode root)
        {
            return helper(root, null, null);
        }

        //中序遍历
        public bool isValid(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            double inorder = Double.MinValue;

            while (stack.Count != 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (root.val <= inorder) return false;
                inorder = root.val;
                root = root.right;
            }
            return true;
        }



    }
}
