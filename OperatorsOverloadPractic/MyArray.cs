using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadPractic
{
    // 2
    class MyArray
    {
        private const int ARRAY_SIZE = 10;
        private int[] array = new int[ARRAY_SIZE];

        public static bool operator > (MyArray firstArray, MyArray secondArray)
        {
            int firstSum = 0;
            int secondSum = 0;

            foreach (int number in firstArray.array)
            {
                firstSum += number;
            }
            foreach (int number in secondArray.array)
            {
                secondSum += number;
            }

            if (firstSum > secondSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(MyArray firstArray, MyArray secondArray)
        {
            int firstSum = 0;
            int secondSum = 0;

            foreach (int number in firstArray.array)
            {
                firstSum += number;
            }
            foreach (int number in secondArray.array)
            {
                secondSum += number;
            }

            if (firstSum < secondSum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
