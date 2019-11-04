using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class ReverseString_344
	{
		public void ReverseString(char[] s)
		{
			if (s != null)
			{
				int i = 0;
				int j = s.Length - 1;
				while (i < j)
				{
					char temp = s[i];
					s[i++] = s[j];
					s[j--] = temp;
				}
			}
			
		}

		//public static void Main(string[] args)
		//{
		//	ReverseString_344 n = new ReverseString_344();
		//	n.ReverseString(new char[] { '1', 's', 'e' });
		//	Console.ReadKey();
		//}
	}
}
