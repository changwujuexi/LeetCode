using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class TopKFrequentElements_347
	{
		//给定一个非空的整数数组，返回其中出现频率前 k 高的元素。
		public IList<int> TopKFrequent(int[] nums, int k)
		{
			Hashtable table = new Hashtable();
			for(int i = 0; i < nums.Length; i++)
			{
				if (table.ContainsKey(nums[i])) table[nums[i]] = (int)table[nums[i]] + 1;
				else table.Add(nums[i], 1);
			}

			BinaryHeap pri = new BinaryHeap(k,table);
			foreach(int key in table.Keys)
			{
				if (pri.mCount < k) pri.Enqueue(key);
				else
				{
					if ((int)table[pri.mItems[0]] < (int)table[key])
					{
						pri.Dequeue();
						pri.Enqueue(key);
					}
				}
			}
			List<int> list = new List<int>();
			for (int i = 0; i < k; i++) list.Add(pri.mItems[i]);
			return list;
		}

		public class BinaryHeap
		{
			//默认容量为6
			private const int DEFAULT_CAPACITY = 6;
			public int mCount;
			public int[] mItems;
			private Hashtable _table;
			private Comparer mComparer;

			public BinaryHeap() : this(DEFAULT_CAPACITY, null) { }

			public BinaryHeap(int capacity, Hashtable table)
			{
				if (capacity < 0)
				{
					throw new IndexOutOfRangeException();
				}
				mItems = new int[capacity];
				mComparer = Comparer.Default;
				_table = table;
			}

			/// <summary>
			/// 增加元素到堆，并从后往前依次对各结点为根的子树进行筛选，使之成为堆，直到根结点
			/// </summary>
			/// <param name="value"></param>
			/// <returns></returns>
			public bool Enqueue(int value)
			{
				if (mCount == mItems.Length)
				{
					ResizeItemStore(mItems.Length * 2);
				}

				mItems[mCount++] = value;
				int position = BubbleUp(mCount - 1);

				return (position == 0);
			}

			/// <summary>
			/// 取出堆的最小值
			/// </summary>
			/// <returns></returns>
			public int Dequeue()
			{
				return Dequeue(true);
			}

			private int Dequeue(bool shrink)
			{
				if (mCount == 0)
				{
					throw new InvalidOperationException();
				}
				int result = mItems[0];
				if (mCount == 1)
				{
					mCount = 0;
					mItems[0] = default(int);
				}
				else
				{
					--mCount;
					//取序列最后的元素放在堆顶
					mItems[0] = mItems[mCount];
					mItems[mCount] = default(int);
					// 维护堆的结构
					BubbleDown();
				}
				if (shrink)
				{
					ShrinkStore();
				}
				return result;
			}

			private void ShrinkStore()
			{
				// 如果容量不足一半以上，默认容量会下降。
				if (mItems.Length > DEFAULT_CAPACITY && mCount < (mItems.Length >> 1))
				{
					int newSize = Math.Max(
						DEFAULT_CAPACITY, (((mCount / DEFAULT_CAPACITY) + 1) * DEFAULT_CAPACITY));

					ResizeItemStore(newSize);
				}
			}

			private void ResizeItemStore(int newSize)
			{
				if (mCount < newSize || DEFAULT_CAPACITY <= newSize)
				{
					return;
				}

				int[] temp = new int[newSize];
				Array.Copy(mItems, 0, temp, 0, mCount);
				mItems = temp;
			}

			public void Clear()
			{
				mCount = 0;
				mItems = new int[DEFAULT_CAPACITY];
			}

			/// <summary>
			/// 从前往后依次对各结点为根的子树进行筛选，使之成为堆，直到序列最后的节点
			/// </summary>
			private void BubbleDown()
			{
				int parent = 0;
				int leftChild = (parent * 2) + 1;
				while (leftChild < mCount)
				{
					// 找到子节点中较小的那个
					int rightChild = leftChild + 1;
					int bestChild = (rightChild < mCount && (int)_table[mItems[rightChild]] < (int)_table[mItems[leftChild]]) ?
						rightChild : leftChild;
					if ((int)_table[mItems[bestChild]] < (int)_table[mItems[parent]])
					{
						// 如果子节点小于父节点, 交换子节点和父节点
						int temp = mItems[parent];
						mItems[parent] = mItems[bestChild];
						mItems[bestChild] = temp;
						parent = bestChild;
						leftChild = (parent * 2) + 1;
					}
					else
					{
						break;
					}
				}
			}

			/// <summary>
			/// 从后往前依次对各结点为根的子树进行筛选，使之成为堆，直到根结点
			/// </summary>
			/// <param name="startIndex"></param>
			/// <returns></returns>
			private int BubbleUp(int startIndex)
			{
				while (startIndex > 0)
				{
					int parent = (startIndex - 1) / 2;
					//如果子节点小于父节点，交换子节点和父节点
					if ((int)_table[mItems[startIndex]]< (int)_table[mItems[parent]])
					{
						int temp = mItems[startIndex];
						mItems[startIndex] = mItems[parent];
						mItems[parent] = temp;
					}
					else
					{
						break;
					}
					startIndex = parent;
				}
				return startIndex;
			}
		}


		//static void Main(string[] args)
		//{
		//	TopKFrequentElements_347 ds = new TopKFrequentElements_347();
		//	int[] nums = new int[] { 5,3,1,1,1,3,5,73,1};
		//	ds.TopKFrequent(nums, 3);
		//}
	}
}
