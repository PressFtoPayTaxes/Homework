using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass
            {
                TestProperty = "Ы"
            };

            test.PropertyChanged += (sender, element) => Console.WriteLine($"{sender} изменил свойство экземпляра класса {element}");

            test.TestProperty = "Ыы";

            Console.ReadLine();
        }
    }
}
