using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class MinStack_155
	{
		public class MinStack
		{
			Stack<int> stack;
			Stack<int> mStack;

			/** initialize your data structure here. */
			public MinStack()
			{
				stack = new Stack<int>();
				mStack = new Stack<int>();
			}

			public void Push(int x)
			{
				stack.Push(x);
				if (mStack.Count == 0 || x <= GetMin())
				{
					mStack.Push(x);
				}
			}

			public void Pop()
			{
				if (stack.Count != 0)
				{
					int val = stack.Pop();
					if (val == GetMin()) mStack.Pop();
				}
				else throw new Exception("11");
			}

			public int Top()
			{
				if (stack.Count != 0) return stack.Peek();
				else throw new Exception("11");
			}

			public int GetMin()
			{
				if (mStack.Count != 0) return mStack.Peek();
				else throw new Exception("11");
			}
			
		}

		//public static void Main(string[] args)
		//{
		//	MinStack num = new MinStack();

		//	num.Push(-2);
		//	num.Push(0);
		//	num.Push(-3);
		//	num.GetMin();
		//	num.Pop();
		//	num.GetMin();
		//	Console.ReadKey();

		//}
	}
}
