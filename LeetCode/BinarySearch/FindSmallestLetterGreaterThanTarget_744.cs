using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FindSmallestLetterGreaterThanTarget_744
	{
		//给定一个只包含小写字母的有序数组letters 和一个目标字母target，寻找有序数组里面比目标字母大的最小字母。
		//数组里字母的顺序是循环的。举个例子，如果目标字母target = 'z' 并且有序数组为 letters = ['a', 'b']，则答案返回 'a'。
		public static char NextGreatestLetter(char[] letters, char target)
		{
			if (letters[0] > target || letters[letters.Length - 1] <= target) return letters[0];
			else
			{
				int left = 0;
				int right = letters.Length - 1;
				int mid = left + (right - left) / 2;
				while (right >= left)
				{
					if (letters[mid] <= target) left = mid + 1;
					else if (letters[mid] > target && letters[mid - 1] <= target) return letters[mid];
					else right = mid;
					mid = left + (right - left) / 2;
				}
			}
			return '1';
		}

		//static void Main(string[] args)
		//{
		//	Console.WriteLine(NextGreatestLetter(new char[] { 'c', 'f', 'j' },'d'));
		//	Console.ReadKey();
		//}
	}
}
