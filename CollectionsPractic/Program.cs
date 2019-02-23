using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Исходный массив: ");
            //foreach(int number in arrayList)
            //{
            //    Console.Write(number + " ");
            //}

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    if ((int)arrayList[i] % 2 == 1)
            //    {
            //        arrayList.RemoveAt(i);
            //        i--;
            //    }
            //}

            //Console.WriteLine("\nМассив без нечетных элементов:");
            //foreach (int number in arrayList)
            //{
            //    Console.Write(number + " ");
            //}


            // 2
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            double averageNumber = 0;
            foreach (int number in list)
            {
                averageNumber += number;
            }
            averageNumber /= list.Count;

            Console.WriteLine("Исходный список:");
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Элементы, которые больше среднего числа в списке: ");
            foreach (int number in list)
            {
                if (number > averageNumber)
                    Console.Write(number + " ");
            }

            Console.ReadLine();
        }
    }
}
