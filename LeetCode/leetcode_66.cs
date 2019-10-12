using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_66
    {
		public int[] PlusOne(int[] digits)
		{
			var digitStack = new Stack<int>();
			bool isPromoted = false;

			if (digits == null || digits.Length == 0)
			{
				return new int[0];
			}

			for (int i = 0; i < digits.Length; i++)
			{
				digitStack.Push(digits[i]);
			}

			var reverseStack = new Stack<int>();
			var last = digitStack.Pop();
			if (last == 9)
			{
				isPromoted = true;
				reverseStack.Push(0);
			}
			else
			{
				isPromoted = false;
				reverseStack.Push(last + 1);
			}

			while (digitStack.Count != 0)
			{
				var nextNumber = digitStack.Pop();
				if (isPromoted)
				{
					if (nextNumber == 9)
					{
						isPromoted = true;
						reverseStack.Push(0);

					}
					else
					{
						isPromoted = false;
						reverseStack.Push(nextNumber + 1);
					}
				}
				else
				{
					reverseStack.Push(nextNumber);
				}
			}

			if (isPromoted)
			{
				reverseStack.Push(1);
			}

			var finalList = new List<int>();
			while (reverseStack.Count != 0)
			{
				var finalElement = reverseStack.Pop();
				finalList.Add(finalElement);
			}
			return finalList.ToArray();
		}
	}
}
