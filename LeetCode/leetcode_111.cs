using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_111
    {
        //深度优先搜索 递归
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if ((root.left == null) && (root.right == null))
            {
                return 1;
            }

            int min_depth = int.MaxValue;
            if (root.left != null)
            {
                min_depth = Math.Min(MinDepth(root.left), min_depth);
            }
            if (root.right != null)
            {
                min_depth = Math.Min(MinDepth(root.right), min_depth);
            }

            return min_depth + 1;
        }

        //宽度优先搜索迭代
        //按树的层次迭代，第一个访问到的叶子就是最小深度的节点
        public int KFSMinDepth(TreeNode root)
        {
            LinkedList<KeyValuePair<TreeNode, int>> stack = new LinkedList<KeyValuePair<TreeNode, int>>();
            if (root == null) return 0;
            else
            {
                stack.AddLast(new KeyValuePair<TreeNode, int>(root, 1));
            }


            int cur_depth = 0;
            while (stack.Count != 0)
            {
                KeyValuePair<TreeNode, int> current = stack.First();
                stack.RemoveFirst();
                root = current.Key;
                cur_depth = current.Value;

                if ((root.left == null) && (root.right == null))
                {
                    break;
                }
                if (root.left != null)
                {
                    stack.AddLast(new KeyValuePair<TreeNode, int>(root.left, cur_depth + 1));
                }
                if (root.right != null)
                {
                    stack.AddLast(new KeyValuePair<TreeNode, int>(root.right, cur_depth + 1));
                }



            }
            return cur_depth;
            
        }

    }
}
