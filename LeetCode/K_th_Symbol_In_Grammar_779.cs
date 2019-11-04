using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class K_th_Symbol_In_Grammar_779
	{
		public int KthGrammar(int N, int K)
		{
			if (N == 1 && K == 1) return 0;
			int a = KthGrammar(N - 1, (K - 1) / 2 + 1);
			if (a == 0)
			{
				if (K % 2 == 1) return 0;
				else return 1;
			}
			else
			{
				if (K % 2 == 1) return 1;
				else return 0;
			}
		}
	}
}
