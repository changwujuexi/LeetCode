using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinaryTree
{
	class SerializeAndDeserializeBinaryTree_297
	{
		// Encodes a tree to a single string.
		public static string serialize(TreeNode root)
		{
			StringBuilder sb = new StringBuilder();

			if (root == null) return "";
			var q1 = new Queue<TreeNode>();
			var q2 = new Queue<TreeNode>();
			q1.Enqueue(root);
			bool flag = true;
			while (true)
			{
				if (q1.Count != 0 && flag) 
				{
					flag = false;
					while (q1.Count != 0)
					{
						var cur = q1.Dequeue();
						if (cur == null)
						{
							sb.Append("null,");
							
							continue;
						}
						
						if (cur.left != null)
						{
							q2.Enqueue(cur.left);
							flag = true;
						}
						else q2.Enqueue(null);
						if (cur.right != null)
						{
							q2.Enqueue(cur.right);
							flag = true;
						}
						else q2.Enqueue(null);
						sb.Append(cur.val + ",");
					}
				}
				else if (q2.Count != 0 && flag) 
				{
					flag = false;
					while (q2.Count != 0)
					{
						var cur = q2.Dequeue();
						if (cur == null)
						{
							sb.Append("null,");
							
							continue;
						}
						flag = true;
						if (cur.left != null)
						{
							q1.Enqueue(cur.left);
							flag = true;
						}
						else q1.Enqueue(null);
						if (cur.right != null)
						{
							q1.Enqueue(cur.right);
							flag = true;
						}
						else q1.Enqueue(null);

						sb.Append(cur.val + ",");
					}
				}
				else break;
			}
			sb.Remove(sb.Length - 1, 1);
			return sb.ToString();
		}

		// Decodes your encoded data to tree.
		public static TreeNode deserialize(string data)
		{
			if (data == "") return null;
			string[] str = data.Split(',');
			var list = str.ToList();

			if (list.First() == null) return null;
			else
			{
				int index = 1;
				
				var q = new Queue<TreeNode>();
				var root = new TreeNode(int.Parse(list[0]));
				q.Enqueue(root);
				while (index < list.Count)
				{
					var cur = q.Dequeue();
					if (cur == null)
					{
						continue;
					}
					else
					{
						if (list[index] == "null")
						{
							cur.left = null;
							q.Enqueue(null);
							index++;
						}
						else
						{
							cur.left = new TreeNode(int.Parse(list[index]));
							q.Enqueue(cur.left);
							index++;
						}
						if (list[index] == "null")
						{
							cur.right = null;
							q.Enqueue(null);
							index++;
						}
						else
						{
							cur.right = new TreeNode(int.Parse(list[index]));
							q.Enqueue(cur.right);
							index++;
						}
					}
					
					
				}
				return root;
			}
		}

		static void Main(string[] args)
		{
			;
			serialize(deserialize("1,3,null,null,4"));
			Console.ReadKey();
		}
	}
}
