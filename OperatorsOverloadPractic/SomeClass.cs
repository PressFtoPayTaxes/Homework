using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloadPractic
{
    // 1
    class SomeClass
    {
        public int Property { get; set; }
        public int AnotherProperty { get; set; }

        public static bool operator == (SomeClass operand1, SomeClass operand2)
        {
            if (operand1.Property == operand2.Property && operand1.AnotherProperty == operand2.AnotherProperty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (SomeClass operand1, SomeClass operand2)
        {
            if (operand1.Property != operand2.Property || operand1.AnotherProperty != operand2.AnotherProperty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
