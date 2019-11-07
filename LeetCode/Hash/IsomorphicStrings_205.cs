using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hash
{
	class IsomorphicStrings_205
	{
		//给定两个字符串 s和 t，判断它们是否是同构的。
		//如果 s中的字符可以被替换得到 t ，那么这两个字符串是同构的。
		//所有出现的字符都必须用另一个字符替换，同时保留字符的顺序。
		//两个字符不能映射到同一个字符上，但字符可以映射自己本身。
		public bool IsIsomorphic(string s, string t)
		{
			char[] cs = s.ToCharArray();
			char[] ct = t.ToCharArray();

			Hashtable hs = new Hashtable();
			Hashtable ht = new Hashtable();

			for(int i = 0; i < cs.Length; i++)
			{
				if (hs.ContainsKey(cs[i]))
				{
					if (ht.ContainsKey(ct[i]))
					{
						if ((int)hs[cs[i]] != (int)ht[ct[i]]) return false;
						hs[cs[i]] = i;
						ht[ct[i]] = i;
					}
					else return false;
				}
				else
				{
					if (ht.ContainsKey(ct[i])) return false;
					hs.Add(cs[i], i);
					ht.Add(ct[i], i);
				}
			}
			return true;
		}

		//static void Main(string[] args)
		//{
		//	var sd = new IsomorphicStrings_205();
		//	sd.IsIsomorphic("egg", "add");
		//}
	}
}
