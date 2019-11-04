using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class LongestCommonPrefix_14
	{
		//编写一个函数来查找字符串数组中的最长公共前缀。

		//如果不存在公共前缀，返回空字符串 ""。
		public string LongestCommonPrefix(string[] strs)
		{
			if (strs.Length == 0) return "";
			string prefix = strs[0];
			for(int i = 1; i < strs.Length; i++)
				while (strs[i].IndexOf(prefix) != 0)
				{
					prefix = prefix.Substring(0, prefix.Length - 1);
					if (prefix == null) return "";
				}
			return prefix;
		}

	}
}
