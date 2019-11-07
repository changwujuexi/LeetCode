using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class MyHashMap
	{
		//不使用任何内建的哈希表库设计一个哈希映射
		//具体地说，你的设计应该包含以下的功能
		//put(key, value)：向哈希映射中插入(键, 值)的数值对。如果键对应的值已经存在，更新这个值。
		//get(key)：返回给定的键所对应的值，如果映射中不包含这个键，返回-1。
		//remove(key)：如果映射中存在这个键，删除这个数值对。

		/** Initialize your data structure here. */

		class Node
		{
			public int key, value;
			public Node prev, next;
			public Node(int key, int value)
			{
				this.key = key;
				this.value = value;
			}
		}

		private Node[] nodeList = new Node[100];
		int len = 100;

		public MyHashMap()
		{
			
		}

		/** value will always be non-negative. */
		public void Put(int key, int value)
		{
			int index = key % len;
			Node node = nodeList[index];
			if (node == null) nodeList[index] = new Node(key, value);
			else
			{
				if (node.key == key)
				{
					node.value = value;
					return;
				}
				while (node.next != null)
				{
					node = node.next;
					if (node.key == key)
					{
						node.value = value;
						return;
					}
				}
				var newNode = new Node(key, value);
				node.next = newNode;
				newNode.prev = node;
				return;

			}
		}

		/** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
		public int Get(int key)
		{
			int index = key % len;
			Node node = nodeList[index];
			
			while (node != null)
			{
				if (node.key == key) return node.value;
				node = node.next;
			}
			return -1;

		}

		/** Removes the mapping of the specified value key if this map contains a mapping for the key */
		public void Remove(int key)
		{
			int index = key % len;
			Node node = nodeList[index];
			if (node == null) return;
			if (node != null && node.key == key)
			{
				var next = node.next;
				if (next != null) next.prev = null;
				nodeList[index] = next;
				return;
			}
			node = node.next;
			while (node != null)
			{
				if (node.key == key)
				{
					node.prev.next = node.next;
					if (node.next != null) node.next.prev = node.prev;
					return;
				}
				node = node.next;
			}
			return;
		}

	}
}
