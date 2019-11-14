using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class GuessNumberHigherOrLower_374
	{
		int n = 6;
		//我们正在玩一个猜数字游戏。 游戏规则如下：
		//我从 1 到 n选择一个数字。 你需要猜我选择了哪个数字。
		//每次你猜错了，我会告诉你这个数字是大了还是小了。
		//你调用一个预先定义好的接口 guess(int num)，它会返回 3 个可能的结果（-1，1 或 0）：
		public static int guessNumber(int n)
		{
			int left = 1, right = n, mid = left + (right - left) / 2;
			int result = guess(mid);
			while (guess(mid) != 0)
			{
				if (result == -1) right = mid - 1;
				else left = mid + 1;
				mid = left + (right - left) / 2;
				result = guess(mid);
			}
			return mid;
		}

		public static int guess(int num)
		{
			return num == 6 ? 0 : (num > 6 ? -1 : 1);
		}

		//static void Main(string[] args)
		//{
		//	guessNumber(10);
		//}
	}
}
