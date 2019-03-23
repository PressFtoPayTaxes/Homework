using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Type stringType = typeof(string);
            //int substringSize = 6;

            //var stroke = Activator.CreateInstance(stringType, new char[] { 'С', 'т', 'р', 'о', 'к', 'а', 'р', 'ы', 'к' });
            //Console.WriteLine(stroke);

            //foreach (var memberInfo in stringType.GetMembers())
            //{
            //    if (memberInfo.Name == "Substring")
            //    {
            //        var method = memberInfo as MethodInfo;

            //        if (method.GetParameters().Length == 2)
            //        {
            //            object[] arguments = new object[] { 0, substringSize };
            //            stroke = method.Invoke(stroke, arguments);
            //        }
            //    }
            //}
            //Console.WriteLine(stroke);

            // 2
            Type listType = typeof(List<>);

            foreach (var memberInfo in listType.GetMembers())
            {
                if (memberInfo is ConstructorInfo)
                {
                    var constructor = memberInfo as ConstructorInfo;
                    Console.Write($"{constructor.Name}(");
                    foreach (var parameter in constructor.GetParameters())
                    {
                        Console.Write($"{parameter.ParameterType} {parameter.Name}");

                    }
                    Console.WriteLine(")");
                }
            }

            Console.ReadLine();
        }
    }
}
