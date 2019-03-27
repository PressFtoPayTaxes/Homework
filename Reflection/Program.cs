using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //var consoleType = typeof(Console);

            //foreach (var member in consoleType.GetMembers())
            //{
            //    if (member is MethodInfo)
            //    {
            //        var method = member as MethodInfo;
            //        Console.Write($"{method.ReturnType.Name} {method.Name}(");

            //        if (method.GetParameters().Count() > 0)
            //        {
            //            foreach (var parameter in method.GetParameters())
            //            {
            //                Console.Write($"{parameter.ParameterType.Name} {parameter.Name}, ");
            //            }
            //            Console.WriteLine($"\b\b);");
            //        }
            //        else
            //        {
            //            Console.WriteLine(");");
            //        }
            //    }
            //}


            // 2
            var humanType = typeof(Human);

            var human = Activator.CreateInstance(humanType) as Human;
            human.Name = "Игорь";
            human.Age = 16;
            human.Height = 176;
            human.Weight = 63;

            foreach(var prop in humanType.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType.Name} {prop.Name} = {prop.GetValue(human)}");
            }

            Console.ReadLine();
        }
    }
}
