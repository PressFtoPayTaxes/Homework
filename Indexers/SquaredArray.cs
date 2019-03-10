using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class SquaredArray
    {
        private const int ARRAY_SIZE = 100;
        public int[] array = new int[ARRAY_SIZE];

        public int this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value * value;
            }
        }
    }
}
