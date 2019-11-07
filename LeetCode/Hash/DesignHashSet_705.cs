using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	//不使用任何内建的哈希表库设计一个哈希集合

	//具体地说，你的设计应该包含以下的功能

	//add(value)：向哈希集合中插入一个值。
	//contains(value) ：返回哈希集合中是否存在这个值。
	//remove(value)：将给定值从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。
	class MyHashSet
	{

		class Node
		{
			public int val;
			public Node prev, next;
			public Node(int val) { this.val = val; }
		}

		private int length = 100;
		private Node[] data = new Node[100];

		/** Initialize your data structure here. */
		public MyHashSet()
		{

		}

		public void Add(int key)
		{
			int index = key % length;
			Node cur = data[index];
			if (cur == null)
			{
				var node = new Node(key);
				data[index] = node;
				return;
			}
			while (true)
			{
				if (cur.val == key) return;
				if (cur.next == null)
				{
					Node node = new Node(key);
					node.prev = cur;
					cur.next = node;
					return;
				}
				else cur = cur.next;
			}
		}

		public void Remove(int key)
		{
			int index = key % length;
			Node cur = data[index];
			if (cur != null && cur.val == key)
			{
				Node next = cur.next;
				if (next != null) next.prev = null;
				data[index] = next;
				return;
			}
			while (cur != null)
			{
				if (cur.val == key)
				{
					Node next = cur.next;
					Node pre = cur.prev;
					if (next != null) next.prev = pre;
					if (pre != null) pre.next = next;
					return;
				}
				cur = cur.next;
			}
		}

		/** Returns true if this set contains the specified element */
		public bool Contains(int key)
		{
			int index = key % length;
			Node cur = data[index];
			while (cur != null)
			{
				if (cur.val == key) return true;
				cur = cur.next;
			}
			return false;
		}

		//static void Main(string[] args)
		//{
		//	MyHashSet ms = new MyHashSet();
		//	ms.Add(1);
		//	ms.Remove(1);
		//	Console.Write(ms.Contains(1));
		//	Console.ReadKey();
		//}
	}
}
