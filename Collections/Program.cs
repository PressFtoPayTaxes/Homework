using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            int firstMaximalNumber = 0;
            int secondMaximalNumber = 0;
            int secondMaximalNumberPosition = 0;

            foreach (int number in list)
            {
                if (number > firstMaximalNumber)
                    firstMaximalNumber = number;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > secondMaximalNumber && list[i] < firstMaximalNumber)
                {
                    secondMaximalNumber = list[i];
                    secondMaximalNumberPosition = i;
                }
            }

            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.Write($"\nВторое максимальное число из списка: {secondMaximalNumber} на позиции {secondMaximalNumberPosition}");

            Console.ReadLine();
        }
    }
}
