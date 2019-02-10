using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWork
{
    class Program
    {
        static void Main(string[] args)
        {            
            // 1
            //const int ONE_DIMENSIONED_ARRAY_SIZE = 5;
            //int[] oneDimensionedArray = new int[5];

            //const int TWO_DIMENSIONED_ARRAY_ROWS = 3;
            //const int TWO_DIMENSIONED_ARRAY_COLS = 4;
            //double[,] twoDimensionedArray = new double[TWO_DIMENSIONED_ARRAY_ROWS, TWO_DIMENSIONED_ARRAY_COLS];

            //Console.WriteLine("Заполните одномерный массив 5 числами: ");
            //for (int i = 0; i < ONE_DIMENSIONED_ARRAY_SIZE; i++)
            //{
            //    oneDimensionedArray[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Одномерный массив:");
            //foreach (int number in oneDimensionedArray)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();

            //int randomNumbersRange = 10;
            //Console.WriteLine("Двумерный массив:");
            //Random randomNumber = new Random();
            //for (int i = 0; i < TWO_DIMENSIONED_ARRAY_ROWS; i++)
            //{
            //    for (int j = 0; j < TWO_DIMENSIONED_ARRAY_COLS; j++)
            //    {
            //        twoDimensionedArray[i, j] = randomNumber.Next(randomNumbersRange);
            //        Console.Write(twoDimensionedArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int minimalElement = oneDimensionedArray[0];
            //int maximalElement = 0;

            //for (int i = 0; i < ONE_DIMENSIONED_ARRAY_SIZE; i++)
            //{
            //    for (int j = 0; j < TWO_DIMENSIONED_ARRAY_ROWS; j++)
            //    {
            //        for (int k = 0; k < TWO_DIMENSIONED_ARRAY_COLS; k++)
            //        {
            //            if (oneDimensionedArray[i] == twoDimensionedArray[j, k])
            //            {
            //                if (oneDimensionedArray[i] > maximalElement)
            //                {
            //                    maximalElement = oneDimensionedArray[i];
            //                }
            //                if (oneDimensionedArray[i] < minimalElement)
            //                {
            //                    minimalElement = oneDimensionedArray[i];
            //                }
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Общий максимальный элемент: " + maximalElement);
            //Console.WriteLine("Общий минимальный элемент: " + minimalElement);

            //double sum = 0;
            //double composition = 1;
            //int sumOfEvenElements = 0;
            //double sumOfUnevenElements = 0;

            //foreach(int number in oneDimensionedArray)
            //{
            //    sum += number;
            //    composition *= number;
            //    if (number % 2 == 0)
            //    {
            //        sumOfEvenElements += number;
            //    }
            //}
            //for (int i = 0; i < TWO_DIMENSIONED_ARRAY_ROWS; i++)
            //{
            //    for (int j = 0; j < TWO_DIMENSIONED_ARRAY_COLS; j++)
            //    {
            //        sum += twoDimensionedArray[i, j];
            //        composition *= twoDimensionedArray[i, j];
            //        if (j % 2 == 1)
            //        {
            //            sumOfUnevenElements += twoDimensionedArray[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine("Сумма элементов массивов: " + sum);
            //Console.WriteLine("Произведение элементов массивов: " + composition);
            //Console.WriteLine("Сумма четных элементов в одномерном массиве: " + sumOfEvenElements);
            //Console.WriteLine("Сумма нечетных столбцов в двумерном массиве: " + sumOfUnevenElements);


            // 2
            //const int FIRST_ARRAY_SIZE = 5;
            //const int SECOND_ARRAY_SIZE = 8;
            //int[] firstArray = new int[FIRST_ARRAY_SIZE];
            //int[] secondArray = new int[SECOND_ARRAY_SIZE];

            //int randomNumbersRange = 15;
            //Console.WriteLine("Первый массив:");
            //Random randomNumber = new Random();
            //for (int i = 0; i < FIRST_ARRAY_SIZE; i++)
            //{
            //    firstArray[i] = randomNumber.Next(randomNumbersRange);
            //    Console.Write(firstArray[i] + " ");
            //}
            //Console.WriteLine("\nВторой массив");
            //for (int i = 0; i < SECOND_ARRAY_SIZE; i++)
            //{
            //    secondArray[i] = randomNumber.Next(randomNumbersRange);
            //    Console.Write(secondArray[i] + " ");
            //}

            //int[] thirdArray = new int[SECOND_ARRAY_SIZE];

            //int counter = 0;
            //for (int i = 0; i < FIRST_ARRAY_SIZE; i++)
            //{
            //    for (int j = 0; j < SECOND_ARRAY_SIZE; j++)
            //    {
            //        if (firstArray[i] == secondArray[j])
            //        {
            //            if (counter == 0)
            //            {
            //                thirdArray[counter] = firstArray[i];
            //                counter++;
            //                break;              
            //            }
            //            else
            //            {
            //                for (int k = 0; k <= counter; k++)
            //                {
            //                    if (firstArray[i] == thirdArray[k])
            //                    {
            //                        break;
            //                    }
            //                    thirdArray[counter] = firstArray[i];
            //                    counter++;
            //                }
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("\nТретий массив");
            //for (int i = 0; i < counter; i++)
            //{
            //    Console.Write(thirdArray[i] + " ");
            //}


            // 3
            //string line = "Удавы рвали лавры в аду";
            //string savedLine = line;

            //line = line.ToLower();
            //for (int i = 0; i < line.Length; i++)
            //{
            //    if (line[i] == ' ')
            //    {
            //        line = line.Remove(i, 1);
            //    }
            //}
            //string reversedLine = string.Concat(line.Reverse());
            //if (line == reversedLine)
            //{
            //    Console.Write($"Строка \"{savedLine}\" является палиндромом");
            //}
            //else
            //{
            //    Console.Write($"Строка \"{savedLine}\" не является палиндромом");
            //}

            // 4
            //string sentence;

            //Console.WriteLine("Введите предложение: ");
            //sentence = Console.ReadLine();
            //sentence.Trim();

            //int emptySpaces = 0;
            //foreach (char symbol in sentence)
            //{
            //    if (symbol == ' ')
            //    {
            //        emptySpaces++;
            //    }
            //}
            //Console.WriteLine("В веденном предложении " + (emptySpaces + 1) + " слов");

            // 5
            const int DIMENSION_SIZE = 5;

            int[,] array = new int[DIMENSION_SIZE, DIMENSION_SIZE];

            Console.WriteLine("Двумерный массив: ");
            Random randomNumber = new Random();
            for (int i = 0; i < DIMENSION_SIZE; i++)
            {
                for (int j = 0; j < DIMENSION_SIZE; j++)
                {
                    array[i, j] = randomNumber.Next(-100, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(" ");
            }

            int minimalElementRow = 0;
            int minimalElementColumn = 0;
            int maximalElementRow = 0;
            int maximalElementColumn = 0;


            for (int i = 0; i < DIMENSION_SIZE; i++)
            {
                for (int j = 0; j < DIMENSION_SIZE; j++)
                {
                    if (array[i, j] < array[minimalElementRow, minimalElementColumn])
                    {
                        minimalElementRow = i;
                        minimalElementColumn = j;
                    }
                    if (array[i, j] > array[maximalElementRow, maximalElementColumn])
                    {
                        maximalElementRow = i;
                        maximalElementColumn = j;
                    }
                }
            }

            int sum = 0;

            int minimalElementPosition = (minimalElementRow + 1) * (minimalElementColumn + 1);
            int maximalElementPosition = (maximalElementRow + 1) * (maximalElementColumn + 1);

            if (minimalElementPosition > maximalElementPosition)
            {
                var temp = maximalElementPosition;
                maximalElementPosition = minimalElementPosition;
                minimalElementPosition = temp;
            }

            for (int i = 0; i < DIMENSION_SIZE; i++)
            {
                for (int j = 0; j < DIMENSION_SIZE; j++)
                {
                    int currentPosition = (i + 1) * (j + 1);
                    if (currentPosition >= minimalElementPosition && currentPosition <= maximalElementPosition)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);

            Console.ReadLine();
        }
    }
}
