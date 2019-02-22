using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //string stroke = "";
            //int emptySpaces = 0;
            //bool isDot = false;

            //Console.Write("Введите строку, заканчивая точкой: ");
            //while (!isDot)
            //{
            //    string temporaryStroke = Console.ReadLine();

            //    foreach (char symbol in temporaryStroke)
            //    {
            //        if (symbol == '.')
            //        {
            //            isDot = true;
            //            break;
            //        }
            //        else
            //        {
            //            stroke += symbol;
            //        }
            //    }
            //}

            //foreach(char symbol in stroke)
            //{
            //    if (symbol == ' ')
            //    {
            //        emptySpaces++;
            //    }
            //}

            //Console.WriteLine("Пробелов: " + emptySpaces);

            // 2
            //int ticket;
            //Console.Write("Введите номер трамвайного билета: ");
            //ticket = int.Parse(Console.ReadLine());

            //int theBiggestSixSignedNumber = 999999;
            //int theSmallestSixSignedNumber = 100000;

            //if (ticket <= theBiggestSixSignedNumber && ticket >= theSmallestSixSignedNumber)
            //{
            //    int firstThreeNumbersSum = 0;
            //    int lastThreeNumbersSum = 0;
            //    int lastSignGetter = 10;
            //    int numberOfSign = 0;

            //    while (ticket != 0)
            //    {
            //        int lastSign = ticket % lastSignGetter;
            //        if (numberOfSign < 3)
            //        {
            //            lastThreeNumbersSum += lastSign;
            //        }
            //        else
            //        {
            //            firstThreeNumbersSum += lastSign;
            //        }
            //        ticket /= lastSignGetter;
            //        numberOfSign++;
            //    }

            //    if (firstThreeNumbersSum == lastThreeNumbersSum)
            //    {
            //        Console.WriteLine("Поздравляем! У вас счастливый билет!!1!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("У вас обычный билет. Ееее.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Это не билет");
            //}

            // 3
            //string yourString;
            //Console.Write("Enter string: ");
            //yourString = Console.ReadLine();

            //char registeresDifference = (char)32;
            //string newString = "";

            //for (int i = 0; i < yourString.Length; i++)
            //{
            //    if (yourString[i] >= 'A' && yourString[i] <= 'Z')
            //    {
            //        newString += (char)(yourString[i] + registeresDifference);
            //    }
            //    else if (yourString[i] >= 'a' && yourString[i] <= 'z')
            //    {
            //        newString += (char)(yourString[i] - registeresDifference);
            //    }
            //}

            //Console.WriteLine("Registers swap: " + newString);

            // 4
            //int minimalNumber, maximalNumber;
            //Console.Write("Введите начало и конец диапазона чисел: ");
            //minimalNumber = int.Parse(Console.ReadLine());
            //maximalNumber = int.Parse(Console.ReadLine());

            //if (maximalNumber <= minimalNumber)
            //{
            //    Console.WriteLine("Диапазон чисел введён некорректно");
            //}
            //else
            //{
            //    int currentNumber = minimalNumber; 

            //    for (int i = 0; i <= (maximalNumber - minimalNumber); i++)
            //    {
            //        for (int j = 0; j < currentNumber; j++)
            //        {
            //            Console.Write(currentNumber + " ");
            //        }
            //        currentNumber++;
            //        Console.WriteLine();
            //    }
            //}

            // 5
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int lastNumberGetter = 10;

            Console.Write("Перевёрнутое число: ");
            while(number != 0)
            {
                Console.Write(number % lastNumberGetter);
                number /= lastNumberGetter;
            }

            Console.ReadLine();
        }
    }
}
