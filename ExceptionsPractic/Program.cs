using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPractic
{
    class Program
    {
        public static void SummonedMethod()
        {
                throw new Exception();
        }

        public static void SummoningMethod()
        {
            try
            {
                SummonedMethod();
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла рекурсия...");
                SummoningMethod();
            }
        }
        static void Main(string[] args)
        {
            SummoningMethod();
        }



    }
}
