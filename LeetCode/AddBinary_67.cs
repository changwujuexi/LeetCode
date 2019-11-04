using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class AddBinary_67
	{
		public string AddBinary(string a, string b)
		{
			if (a == null)
			{
				if (b == null) return null;
				return b;
			}
			if (b == null) return a;

			char[] chara = a.ToArray();
			char[] charb = b.ToArray();

			int inp = 0;
			var list = new List<int>();

			int al = chara.Length;
			int bl = charb.Length;

			int i = al - 1;
			int j = bl - 1;

			while (i >= 0 || j >= 0)
			{
				if (i < 0)
				{
					int ans = charb[j--] - '0' + inp;
					if (ans == 2)
					{
						inp = 1;
						list.Add(0);
					}
					else if (ans == 1)
					{
						inp = 0;
						list.Add(1);
					}
					else
					{
						inp = 0;
						list.Add(0);
					}

				}
				else if (j < 0)
				{
					int ans = chara[i--] - '0' + inp;
					if (ans == 2)
					{
						inp = 1;
						list.Add(0);
					}
					else if (ans == 1)
					{
						inp = 0;
						list.Add(1);
					}
					else
					{
						inp = 0;
						list.Add(0);
					}
				}
				else
				{
					int ans = chara[i--] - '0' + charb[j--] - '0' + inp;
					switch (ans)
					{
						case 0:
							inp = 0;
							list.Add(0);
							break;
						case 1:
							inp = 0;
							list.Add(1);
							break;
						case 2:
							inp = 1;
							list.Add(0);
							break;
						case 3:
							inp = 1;
							list.Add(1);
							break;
					}
				}
			}
			if (inp == 1) list.Add(1);
			list.Reverse();
			return string.Join("",list.ToArray());
		}
		//static void Main(string[] args)
		//{
		//	string a = "1010";
		//	string b = "1011";
		//	AddBinary_67 DA = new AddBinary_67();
		//	Console.WriteLine(DA.AddBinary(a, b));
		//	Console.ReadKey();
		//}
	}
	
}
