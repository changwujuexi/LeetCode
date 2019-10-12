using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class TreeNode
    {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int x) { val = x; }
    }

    class leetcode_94
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            help(root);
            return ls;
        }

        List<int> ls = new List<int>();

        public void help(TreeNode treeNode)
        {
            if (treeNode.left != null) help(treeNode.left);           
            ls.Add(treeNode.val);
            if (treeNode.right != null) help(treeNode.right);
        }

        //基于栈的遍历
        public IList<int> StackInorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null) return list;
            var stack = new Stack<TreeNode>();
            var temp = root;
            while (temp != null || stack.Count != 0)
            {
                while (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.left;
                }
                temp = stack.Pop();
                list.Add(temp.val);
                temp = temp.right;
            }
            return list;

        }

        //莫里斯遍历
        public List<int> morris(TreeNode root)
        {
            List<int> res = new List<int>();
            TreeNode curr = root;
            TreeNode pre;
            while (curr != null)
            {
                if (curr.left == null)
                {
                    res.Add(curr.val);
                    curr = curr.right;
                }
                else
                {
                    pre = curr.left;
                    while (pre.right != null)
                    {
                        pre = pre.right;
                    }
                    pre.right = curr;
                    TreeNode temp = curr;
                    curr = curr.left;
                    temp.left = null;
                }
            }
            return res;
        }


    }
}
