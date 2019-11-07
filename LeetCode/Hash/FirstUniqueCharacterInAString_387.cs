using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class FirstUniqueCharacterInAString_387
	{
		//给定一个字符串，找到它的第一个不重复的字符，并返回它的索引。如果不存在，则返回 -1。
		public int FirstUniqChar(string s)
		{
			if (s == "") return -1;
			Hashtable ht = new Hashtable();
			Dictionary<char, int> dic = new Dictionary<char, int>();
			char[] cs = s.ToArray();
			for(int i = 0; i < cs.Length; i++)
			{
				if (ht.Contains(cs[i])) dic.Remove(cs[i]);
				else
				{
					ht.Add(cs[i],i);
					dic.Add(cs[i],i);
				}
			}
			if (dic.Count == 0) return -1;
			return dic.Values.Min();
		}

		//private static void Main(string[] args)
		//{
		//	var sd = new FirstUniqueCharacterInAString_387();
		//	sd.FirstUniqChar("loveleetcode");
		//}
	}
}
