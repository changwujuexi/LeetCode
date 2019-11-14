using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class GroupAnagrams_49
	{
		//给定一个字符串数组，将字母异位词组合在一起。字母异位词指字母相同，但排列不同的字符串。

		//示例:

		//输入: ["eat", "tea", "tan", "ate", "nat", "bat"],
		//输出:
		//[
		//  ["ate","eat","tea"],
		//  ["nat","tan"],
		//  ["bat"]
		//]

		public IList<IList<string>> GroupAnagrams(string[] strs)
		{
			List<List<string>> list = new List<List<string>>();
			Hashtable args = new Hashtable();
			Hashtable table = new Hashtable();
		    table.Add('a', 2);
			table.Add('b', 3);
			table.Add('c', 5);
			table.Add('d', 7);
			table.Add('e', 11);
			table.Add('f', 13);
			table.Add('g', 17);
			table.Add('h', 19);
			table.Add('i', 23);
			table.Add('j', 29);
			table.Add('k', 31);
			table.Add('l', 37);
			table.Add('m', 41);
			table.Add('n', 43);
			table.Add('o', 47);
			table.Add('p', 53);
			table.Add('q', 59);
			table.Add('r', 61);
			table.Add('s', 67);
			table.Add('t', 71);
			table.Add('u', 73);
			table.Add('v', 79);
			table.Add('w', 83);
			table.Add('x', 89);
			table.Add('y', 97);
			table.Add('z', 101);

			int index = 0;

			foreach(string str in strs)
			{
				char[] cs = str.ToArray();
				int num = 1;
				foreach (char c in cs) num *= (int)table[c];
				if (args.ContainsKey(num)) list[(int)args[num]].Add(str);

				else
				{
					args.Add(num, index);
					list.Add(new List<string>());
					list[index].Add(str);
					index++;
				}

			}

			for (int i = 0; i < list.Count; i++) list[i].ToArray();
			return list.ToArray();

		}
			

		//private static void Main(string[] args)
		//{
		//	var fs = new GroupAnagrams_49();
		//	fs.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
		//}
	
	}
}
