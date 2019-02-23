using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresAndEnumsPractic
{
    public struct Student : IComparable
    {
        public string fio;
        public string group;
        public double averageMark;
        public int profitOnFamilyMember;
        public Genders gender;
        public StudyForm studyForm;

        public int CompareTo(object obj)
        {
            Student someStudent = (Student)obj;
            return someStudent.averageMark.CompareTo(averageMark);
        }
    }
}
