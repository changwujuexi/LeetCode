using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class EvaluateReversePolishNotation_150
	{
		public int EvalRPN(string[] tokens)
		{
			var stack = new Stack<int>();
			foreach(string res in tokens)
			{
				switch (res)
				{
					case "+":
						stack.Push(stack.Pop() + stack.Pop());
						break;
					case "-":
						stack.Push(-stack.Pop() + stack.Pop());
						break;
					case "*":
						stack.Push(stack.Pop() * stack.Pop());
						break;
					case "/":
						int num = stack.Pop();
						stack.Push(stack.Pop() / num);
						break;
					default:
						stack.Push(int.Parse(res));
						break;

				}

			}
			return stack.Peek();
			

		}

		



	}


}
