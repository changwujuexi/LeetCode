using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode
{
	// Definition for a Node.
	public class Node
	{
		public int val;
		public IList<Node> neighbors;

		public Node() { }
		public Node(int _val, IList<Node> _neighbors)
		{
			val = _val;
			neighbors = _neighbors;
		}
	}

	class CloneGraph_133
	//给定无向连通图中一个节点的引用，返回该图的深拷贝（克隆）。图中的每个节点都包含它的值 val（Int） 和其邻居的列表（list[Node]）。
	{
		public Node CloneGraph(Node node)
		{
			if (node == null) return node;
			var newNode = new Node();
			newNode.neighbors = new List<Node>();
			newNode.val = node.val;
			var stack = new Stack<Node>();
			var dic = new Dictionary<int, Node>();
			stack.Push(node);
			dic.Add(newNode.val, newNode);

			while (stack.Count != 0)
			{
				Node cur = stack.Pop();
				int nNumber = cur.neighbors.Count;
				for (int i = 0; i < nNumber; i++)
				{
					Node temp = cur.neighbors[i];
					if (!dic.ContainsKey(temp.val))
					{
						var n = new Node();
						n.val = temp.val;
						n.neighbors = new List<Node>();
						dic.Add(n.val, n);
						stack.Push(temp);

					}
					dic[cur.val].neighbors.Add(dic[temp.val]);
				}
			}
			return dic[node.val];
		}

		//static void Main(string[] args)
		//{
		//	CloneGraph_133 nus = new CloneGraph_133();
		//	nus.CloneGraph(new Node { });
		//}

	}
}
