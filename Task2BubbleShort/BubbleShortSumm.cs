using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2BubbleShort
{
    class BubbleShortSumm : BubbleShort
    {
        public BubbleShortSumm(int[][] array)
            : base()
        {
        }
        protected override void UpdateKey(int i, int j)
        {
            _keys[i] += _array[i][j];
        }
    }
}
