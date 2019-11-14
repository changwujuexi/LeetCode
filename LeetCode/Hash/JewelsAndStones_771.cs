using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class JewelsAndStones_771
	{
		//给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。 
		//S 中每个字符代表了一种你拥有的石头的类型，你想知道你拥有的石头中有多少是宝石。
		//J 中的字母不重复，J 和S中的所有字符都是字母。字母区分大小写，因此"a"和"A"是不同类型的石头。
		public int NumJewelsInStones(string J, string S)
		{
			char[] js = J.ToArray();
			char[] ss = S.ToArray();
			HashSet<char> set = new HashSet<char>();
			int num = 0;
			for(int i = 0; i < js.Length; i++)
			{
				set.Add(js[i]);
			}

			for(int j = 0; j < ss.Length; j++)
			{
				if (set.Contains(ss[j])) num++;
			}
			return num;
		}

	}
}
