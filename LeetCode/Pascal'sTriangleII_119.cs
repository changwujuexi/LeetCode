using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class Pascal_sTriangleII_119
	{
		public IList<int> GetRow(int rowIndex)
		{
			var pascal = new Queue<int>();
			pascal.Enqueue(1);
			if (rowIndex == 0) return new List<int>(pascal);
			pascal.Enqueue(1);
			if (rowIndex == 1) return new List<int>(pascal);
			else
			{
				for (int i = 2; i < rowIndex + 1; i++)
				{
					pascal.Enqueue(1);
					int temp1 = pascal.Dequeue();
					int temp2;
					for (int j = 1; j < i; j++)
					{
						temp2 = pascal.Dequeue();
						pascal.Enqueue(temp1 + temp2);
						temp1 = temp2;
					}
					pascal.Enqueue(1);
				}
			}
			return new List<int>(pascal);
		}

		//static void Main(string[] args)
		//{
		//	var v = new Pascal_sTriangleII_119();
		//	v.GetRow(3);
		//	Console.ReadKey();
		//}
	}
}
