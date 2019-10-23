using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class DecodeString_394
	{
		public string DecodeString(string s)
		{
			return Dfs(s, 0)[0];
		}

		private string[] Dfs(String s, int i)
		{
			var res = new StringBuilder();
			int muilti = 0;
			while (i < s.Length)
			{
				char c = s[i];
				if (c >= '0' && c <= '9')
					muilti = muilti * 10 + (c - '0');
				else if (c == '[')
				{
					string[] temp = Dfs(s, i + 1);
					i = int.Parse(temp[0]);
					while (muilti > 0)
					{
						res.Append(temp[1]);
						muilti--;
					}
				}
				else if (c == ']')
					return new string[] { i.ToString(), res.ToString() };
				else
					res.Append(c);
				i++;
			}
			return new string[] { res.ToString() };
		}

		//static void Main(string[] args)
		//{
		//	DecodeString_394 nus = new DecodeString_394();
		//	string n = nus.DecodeString("3[a]2[bc]");
		//	Console.WriteLine(n);
		//	Console.ReadKey();
		//}
	}
}
