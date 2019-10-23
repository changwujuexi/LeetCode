using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ValidParentheses
	{
		//		给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。

		//有效字符串需满足：

		//左括号必须用相同类型的右括号闭合。
		//左括号必须以正确的顺序闭合。
		//注意空字符串可被认为是有效字符串。
		public bool IsValid(string s)
		{
			if (s == "") return true;
			Stack<char> stack = new Stack<char>();
			char[] chars = s.ToCharArray();

			for(int i = 0; i < chars.Length; i++)
			{
				if (stack.Count == 0) stack.Push(chars[i]);
				else if (IfMatch(stack.Peek(), chars[i])) stack.Pop();
				else stack.Push(chars[i]);
			}

			if (stack.Count == 0) return true;
			return false;

		}

		public bool IfMatch(char c1, char c2)
		{

			if (c1 == '(' && c2 == ')') return true;
			else if (c1 == '[' && c2 == ']') return true;
			else if (c1 == '{' && c2 == '}') return true;
			else return false;
		}

	}
}
