using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractic
{
    class RangeOfArray
    {
        private const int ARRAY_SIZE = 100;
        private int[] array = new int[ARRAY_SIZE];
        public int MinimalIndex { get; set; }
        public int MaximalIndex { get; set; }

        public int this[int i]
        {
            get
            {
                if (MinimalIndex > MaximalIndex)
                {
                    return -1;
                }
                if (i > MaximalIndex)
                {
                    return array[MaximalIndex - MinimalIndex];
                }
                if (i >= MinimalIndex && i <= MaximalIndex)
                {
                    return array[i - MinimalIndex];
                }
                return array[0];
            }
            set
            {
                if (MinimalIndex < MaximalIndex)
                {
                    if (i >= MinimalIndex && i <= MaximalIndex)
                    {
                        array[i - MinimalIndex] = value;
                    }
                    else if (i > MaximalIndex)
                    {
                        array[MaximalIndex - MinimalIndex] = value;
                    }
                    else
                    {
                        array[0] = value;
                    }
                }
            }
        }

    }
}
