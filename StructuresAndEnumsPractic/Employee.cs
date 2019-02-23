using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnumsPractic
{
    public struct Employee : IComparable        
    {
        public string name;
        public Vacancies vacancy;
        public int salary;
        public int[] applyDate;

        public int CompareTo(object obj)
        {
            Employee someObject = (Employee)obj;
            return someObject.name.CompareTo(name);
        }
    }
}
