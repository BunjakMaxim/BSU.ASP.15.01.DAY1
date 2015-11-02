using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Task2BubbleShort
{
    class BubbleShortSumm : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return x.Sum() - y.Sum(); 
        }
    }
}
