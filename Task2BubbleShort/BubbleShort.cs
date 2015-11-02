using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Task2BubbleShort
{
    class BubbleShort
    {
        IComparer<int[]> comparer;

        public BubbleShort(IComparer<int[]> comp)
        {
            this.comparer = comp;
        }

        public void Short(int[][] array)
        {
            int iStrart = 0, iEnd = array.Length - 1;

            while (iStrart < iEnd)
            {
                for (int j = iStrart; j < iEnd; j++)
                    if (comparer.Compare(array[j], array[j+1]) < 0)
                    {
                        int[] a = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = a;
                    }
                iEnd--;
            }
        }
    }
}
