using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
	class FirstBadVersion_278
	{
		public bool IsBadVersion(int mid)
		{
			return true;
		}
		public int FirstBadVersion(int n)
		{
			int start = 1;
			int end = n;
			int mid = start + (end - start) / 2;
			while (start < end)
			{
				if (mid == 1) return IsBadVersion(mid) ? mid : mid + 1;
				if (!IsBadVersion(mid)) start = mid + 1;
				else if (IsBadVersion(mid) && !IsBadVersion(mid - 1)) return mid;
				else if (IsBadVersion(mid) && IsBadVersion(mid - 1)) end = mid;
				mid = start + (end - start) / 2;
			}
			return mid;
		}
	}
}
