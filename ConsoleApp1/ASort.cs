using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ASort
    {
        public static void Sort(object[] objs, CompareObj cmp)
        {
            for (int i = 0; i < objs.Length - 1; i++)
                for (int j = i + 1; j < objs.Length; j++)
                    if (!cmp(objs[i], objs[j])) swap(ref objs[i], ref objs[j]);
        }

        private static  void swap(ref object v1, ref object v2)
        {
            object temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
