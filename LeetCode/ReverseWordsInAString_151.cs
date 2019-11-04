using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ReverseWordsInAString_151
	{
		public string ReverseWords(string s)
		{
			if (s == null) return "";
			char[] c = s.ToCharArray();
			int len = c.Length;
			int i = len - 1;

			while (i >= 0 && c[i] == ' ') i--;

			int left = i + 1;
			int right = i + 1;

			StringBuilder sb = new StringBuilder(i + 1);

			for (; i >= 0; i--)
			{
				if(c[i]==' ')
				{
					if (right != left) sb.Append(c, left, right - left).Append(" ");
					left = i;
					right = i;
					continue;
				}
				left = i;
			}
			if (right != left) return sb.Append(c, left, right - left).ToString();
			return sb.Length > 0 ? sb.ToString(0, sb.Length - 1) : "";
		}
		//static void Main(string[] args)
		//{
		//	var sda = new ReverseWordsInAString_151();
		//	string s = "hello world my friend  ";
		//	string bak = sda.ReverseWords(s);
		//}

	}
}


