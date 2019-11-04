using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ReverseWordsInAStringIII_557
	{
		//给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。
		public string ReverseWords(string s)
		{
			int l = s.Length;
			if (l==0) return s;
			string[] ss = s.Split(' ');
			int len = ss.Length;
			for(int i = 0; i < len; i++)
			{
				char[] cs = ss[i].ToArray();
				int pre = 0;
				int tail = cs.Length - 1;
				while (pre < tail)
				{
					char temp = cs[pre];
					cs[pre] = cs[tail];
					cs[tail] = temp;
					pre++;
					tail--;
				}
				ss[i] = new string(cs);
			}
			StringBuilder sb = new StringBuilder(l);
			for (int i = 0; i < len; i++) sb.Append(ss[i] + " ");
			sb.Remove(l, 1);
			return sb.ToString();
		}
	}
}
