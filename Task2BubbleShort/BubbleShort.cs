using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2BubbleShort
{
    abstract class BubbleShort
    {
        protected int[] _keys;
        protected int[][] _array;

        public BubbleShort() { }
        public BubbleShort(int[][] array)
        {
            this._array = array;
            this._keys = new int[array.Length];
        }
        protected abstract void UpdateKey(int i, int j);
        public void Short(bool flag = false)
        {
            SetKeys(flag);
            int iStrart = 0, iEnd = _keys.Length - 1;
            while (iStrart < iEnd)
            {
                for (int j = iStrart; j < iEnd; j++)
                    if (_keys[j] > _keys[j + 1])
                    {
                        int m = _keys[j];
                        _keys[j] = _keys[j + 1];
                        _keys[j + 1] = m;
                        int[] a = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = a;
                    }
                iEnd--;
            }
        }
        private void SetKeys(bool flag)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Length > 0)
                {
                    _keys[i] = _array[i][0];

                    for (int j = 1; j < _array[i].Length; j++)
                        UpdateKey(i, j);
                }
                else
                    _keys[i] = int.MinValue;
            }

            if (flag)
                Invert();
        }
        private void Invert()
        {
            int max = _keys.Max();

            for (int i = 0; i < _keys.Length; i++)
                unchecked
                {
                    _keys[i] = max - _keys[i];
                }
        }
    }
}
