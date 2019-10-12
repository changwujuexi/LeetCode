using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_501
    {
        //放入字典，找到最多的数
        public int[] FindMode(TreeNode root)
        {
            var curr = root;
            int? first = null;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            while (stack.Count != 0 || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                int currint = curr.val;
                if (currint == first)
                {
                    dic[currint]++;
                }
                else
                {
                    dic.Add(currint, 1);
                }
                first = currint;
                curr = curr.right;
            }

            if (dic.Count == 0) return new int[] { };

            int a = dic.Values.Max();
            List<int> list = new List<int>();
            foreach (KeyValuePair<int, int> kvp in dic)
            {
                if (kvp.Value.Equals(a))
                {
                    list.Add(kvp.Key);
                }
            }
            return list.ToArray();

        }
    }

    class AnotherSolution
    {
        List<int> list = new List<int>();
        TreeNode pre;
        int max = 0;
        int curr = 1;
        public int[] findMode(TreeNode root)
        {
            if (root == null) return new int[] { };
            inorder(root);
            int[] a = new int[list.Count];
            for(int i = 0; i < list.Count; i++)
            {
                a[i] = list[i];
            }
            return a;
        }

        private void inorder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            inorder(root.left);
            if (pre != null)
            {
                if (pre.val == root.val)
                {
                    curr++;
                }
                else
                {
                    curr = 1;
                }
            }
            if (curr == max)
            {
                list.Add(root.val);
            }
            if (curr > max)
            {
                list.Clear();
                list.Add(root.val);
                max = curr;
            }
            pre = root;
            inorder(root.right);

        }



    }


}
