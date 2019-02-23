using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionInClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 5;
            Plane[] planes = new Plane[arraySize];

        }
    }

    public partial class Plane
    {
        public void AdditionalMethod()
        {
            Console.WriteLine("Method from another class");
        }
    }
}
