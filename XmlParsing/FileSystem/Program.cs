using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //string filePath = @"C:\Fibonacci numbers.txt";

            //ArrayList listNumbers = new ArrayList();
            //string[] arrayNumbers;

            //using (StreamReader stream = new StreamReader(filePath))
            //{
            //    arrayNumbers = stream.ReadToEnd().Split(' ');
            //}

            //Console.WriteLine("Числа Фибоначчи, которые уже были в файле");
            //foreach (string number in arrayNumbers)
            //{
            //    listNumbers.Add(int.Parse(number));
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("Последовательность Фибоначчи была дописана числами");
            //using (StreamWriter writer = new StreamWriter(filePath, true))
            //{
            //    for (int i = 0; i < arrayNumbers.Count(); i++)
            //    {
            //        int lastNumber = (int)listNumbers[listNumbers.Count - 1];
            //        int beforeLastNumber = (int)listNumbers[listNumbers.Count - 2];
            //        int nextNumber = lastNumber + beforeLastNumber;
            //        listNumbers.Add(nextNumber);
            //        writer.Write(' ');
            //        writer.Write(nextNumber);
            //        Console.WriteLine(nextNumber);
            //    }
            //}

            // 2
            string inputFilePath = @"C:\INPUT.txt";
            string outputFilePath = @"C:\OUTPUT.txt";

            string[] numbers;

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                numbers = reader.ReadToEnd().Split(' ');
            }

            Console.WriteLine("Числа в INPUT файле");
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("В OUTPUT файл записано число");
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                int number = int.Parse(numbers[0]) + int.Parse(numbers[1]);
                writer.Write(number);
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
