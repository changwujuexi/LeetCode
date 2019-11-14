using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class RandomizedSet
	{
		Hashtable value;
		Hashtable index;
		List<int> list = new List<int>();
		int size;

		public RandomizedSet()
		{
			value = new Hashtable();
			index = new Hashtable();
			size = 0;
		}

		/** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
		public bool Insert(int val)
		{
			if (index.Contains(val)) return false;
			value.Add(++size, val);
			index.Add(val, size);
			
			return true;
		}

		/** Removes a value from the set. Returns true if the set contained the specified element. */
		public bool Remove(int val)
		{
			if (!index.Contains(val)) return false;
			int curIndex = (int)index[val];
			if (curIndex == size)
			{
				index.Remove(val);
				value.Remove(size--);
			}
			else
			{
				index.Remove(val);
				value.Remove(curIndex);
				int lastValue = (int)value[size];
				value.Add(curIndex, lastValue);
				value.Remove(size--);

				index[lastValue] = curIndex;
			}
			return true;
		}

		/** Get a random element from the set. */
		public int GetRandom()
		{
			int randIndex = new Random().Next(value.Count) + 1;
			return (int)value[randIndex];

		}
	}
}
