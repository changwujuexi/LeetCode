using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class DailyTemperatures_739
	{
		public int[] DailyTemperatures(int[] T)
		{
			//根据每日 气温 列表，请重新生成一个列表，对应位置的输入是你需要再等待多久温度才会升高超过该日的天数。如果之后都不会升高，请在该位置用0 来代替。

			//例如，给定一个列表 temperatures = [73, 74, 75, 71, 69, 72, 76, 73]，你的输出应该是[1, 1, 4, 2, 1, 1, 0, 0]。

			//提示：气温 列表长度的范围是[1, 30000]。每个气温的值的均为华氏度，都是在[30, 100]范围内的整数。

			var Tr = new int[T.Length];
			var stack = new Stack<int>();
			var numStack = new Stack<int>();
			stack.Push(T[0]);
			numStack.Push(0);
			int i = 1;
			while (i < T.Length)
			{
				while (stack.Count != 0 && T[i] > stack.Peek())
				{
					stack.Pop();
					int numBefore = numStack.Pop();
					Tr[numBefore] = i - numBefore;
				}

				stack.Push(T[i]);
				numStack.Push(i++);
			}
			return Tr;
		}

		//static void Main(string[] args)
		//{
		//	DailyTemperatures_739 nus = new DailyTemperatures_739();
		//	nus.DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
		//}

	}
}
