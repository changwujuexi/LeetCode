using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class FourSum_454
	{
		public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
		{
			int ans = 0;
			var dic = new Dictionary<int, int>();
			foreach(int i in A)
			{
				foreach(int j in B)
				{
					int key = i + j;
					//性能不好,TryGetValue更安全，找不到时返回false，ContainsKey判断后会抛出异常导致真机卡死。
					//if (dic.ContainsKey(key)) dic[key]++;
					int value;
					if (dic.TryGetValue(key, out value)) dic[key] = value + 1;
					else dic.Add(key, 1);
					
				}
			}

			foreach(int i in C)
			{
				foreach(int j in D)
				{
					int key = -i - j;
					int value;
					if (dic.TryGetValue(key, out value)) ans+=dic[key];
				}
			}

			return ans;
		}
	}
}
