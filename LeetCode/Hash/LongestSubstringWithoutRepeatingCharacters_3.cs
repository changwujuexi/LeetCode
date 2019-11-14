using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class LongestSubstringWithoutRepeatingCharacters_3
	{
		//给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
		public int LengthOfLongestSubstring(string s)
		{
			HashSet<char> set = new HashSet<char>();
			char[] cs = s.ToArray();
			if (s.Equals("")) return 0;

			int len = cs.Length;
			if (len == 1) return 1;

			set.Add(cs[0]);

			int maxNum = 1;
			int num = 1;
			
			for(int i = 0, j = 1; i < len; i++)
			{
				for (; j < len; j++)
				{
					if (!set.Contains(cs[j]))
					{
						set.Add(cs[j]);
						num++;
					}
					else
					{
						if (maxNum < num) maxNum = num;
						num -= 1;
						set.Remove(cs[i]);
						break;
					}
				}
			}
			return maxNum > num ? maxNum : num;
		}

		//static void Main(string[] args)
		//{
		//	LongestSubstringWithoutRepeatingCharacters_3 das = new LongestSubstringWithoutRepeatingCharacters_3();
		//	das.LengthOfLongestSubstring("au");

		//}
	}
}
