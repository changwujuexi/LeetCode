using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class MinimumIndexSumOfTwoLists_599
	{
		//假设Andy和Doris想在晚餐时选择一家餐厅，并且他们都有一个表示最喜爱餐厅的列表，每个餐厅的名字用字符串表示。
		//你需要帮助他们用最少的索引和找出他们共同喜爱的餐厅。 
		//如果答案不止一个，则输出所有答案并且不考虑顺序。 你可以假设总是存在一个答案。

		public string[] FindRestaurant(string[] list1, string[] list2)
		{
			Hashtable ht = new Hashtable();
			for (int i = 0; i < list1.Length; i++) ht.Add(list1[i], i);
			List<string> res = new List<string>();
			int min_sum = int.MaxValue, sum;
			for(int i = 0; i < list2.Length; i++)
			{
				if (ht.ContainsKey(list2[i]))
				{
					sum = i + (int)ht[list2[i]];
					if (sum < min_sum)
					{
						res.Clear();
						res.Add(list2[i]);
						min_sum = sum;
					}
					else if (sum == min_sum) res.Add(list2[i]);
				}
			}
			return res.ToArray();
		}

	}
}
