using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class leetcode_28
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == "")
                return 0;
            if (haystack == "")
                return -1;

            if (needle.Length > haystack.Length)
                return -1;

            int i, j;

            if (needle.Length == 1)
            {
                for (i = 0; i < haystack.Length; i++)
                    if (haystack[i] == needle[0])
                        return i;
                return -1;
            }

            int[] next = GetNext1(needle);

            i = 0;
            j = 0;

            while (i < haystack.Length && j < needle.Length)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
                if (j == -1)
                {
                    i++;
                    j = 0;
                }
            }

            if (j == needle.Length)
                return i - needle.Length;
            return -1;




        }
        //自写
        public static int[] GetNext(string p)
        {
            int[] next = new int[p.Length];
            next[0] = -1;
            next[1] = 0;
            int k = 0;
            for(int j = 1; j < p.Length-1; j++)
            {

                if (p[j] == p[k]) next[j + 1] = ++k;
                else if (next[k] == -1) next[j + 1] = 0;
                else if (p[j] == p[next[k]])
                {
                    next[j + 1] = next[k] + 1;
                    k = next[k] + 1;
                }
                else
                {
                    next[j + 1] = 0;
                    k = 0;
                }
      
            }
            return next;
        }

        static int[] GetNext1(string p)
        {
            int[] next = new int[p.Length];
            next[0] = -1;
            next[1] = 0;
            int i = 2;
            while (i < p.Length)
            {
                if (p[i - 1] == p[next[i - 1]])
                {
                    next[i] = next[i - 1] + 1;
                }
                else
                {
                    int k = i - 1;
                    while (next[k] >= 0 && p[i - 1] != p[next[k]])
                        k = next[k];
                    next[i] = next[k] + 1;
                }
                i++;
            }
            return next;
        }



        //static void Main(string[] args)
        //{
        //    int[] next = GetNext("bbabba");

        //    int[] next1 = GetNext1("bbabba");
        //    for (int i = 0; i < next1.Length; i++)
        //    {
        //        Console.WriteLine(next1[i]);
        //    }

        //    for (int i = 0; i < next.Length; i++)
        //    {
        //        Console.WriteLine(next[i]);
        //    }
        //    Console.WriteLine(Enumerable.SequenceEqual(next, next1));
        //    int num = StrStr("bbababaaaababbaabbbabbbaaabbbaaababbabaabbaaaaabbaaabbbbaaabaabbaababbbaabaaababbaaabbbbbbaabbbbbaaabbababaaaaabaabbbababbaababaabbaa", "bbabba");
        //    Console.WriteLine(num);

        //    System.Console.ReadKey();
        //}

    }
}
