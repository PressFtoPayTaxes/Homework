using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespacesAndExceptions
{
    class Program
    {
        // 1  
        public static double Dividing(double divided, double divider)
        {
            double quotient;
            try
            {
                if (divider == 0)
                {
                    throw new ArgumentException();
                }
                quotient = divided / divider;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Аргументы не заданы :0");
                quotient = -1;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Вы делите на нуль :0");
                quotient = -1;
            }

            return quotient;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Dividing(5, 0));

            // 2
            const int ARRAY_SIZE = 5;
            int[] errorArray = new int[ARRAY_SIZE];

            try
            {
                for (int i = 0; i <= ARRAY_SIZE; i++)
                {
                    errorArray[i] = i;
                    Console.WriteLine(errorArray[i]);
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Вы вышли за пределы массива");
            }
            finally
            {
                Console.WriteLine("Обработка массива закончена");
            }
            

            Console.ReadLine();
        }
    }
}
