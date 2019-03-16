using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructuresAndEnumsPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //Employee[] employees;
            //Write("Введите количество сотрудников: ");
            //int employeesCount = int.Parse(ReadLine());
            //employees = new Employee[employeesCount];

            //int minimumVacancyNumber = 0;
            //int maximumVacancyNumber = 6;
            //int dateNumbers = 3;

            //int enteredNumber;
            //for (int i = 0; i < employeesCount; i++)
            //{
            //    Write("Введите имя сотрудника: ");
            //    employees[i].name = ReadLine();
            //    WriteLine("Введите вакансию\n0 - Менеджер\n1 - Босс\n2 - Клерк\n3 - Продавец\n4 - Уборщик\n5 - Грузчик\n6 - Маркетолог");
            //    enteredNumber = int.Parse(ReadLine());
            //    while (true)
            //    {
            //        if (enteredNumber >= minimumVacancyNumber && enteredNumber <= maximumVacancyNumber)
            //        {
            //            employees[i].vacancy = (Vacancies)enteredNumber;
            //            break;
            //        }
            //        else
            //        {
            //            Write("Ваше число не входит в указанный диапазон. Попробуйте ещё раз: ");
            //            enteredNumber = int.Parse(ReadLine());
            //        }
            //    }
            //    Write("Введите зарплату: ");
            //    employees[i].salary = int.Parse(ReadLine());
            //    Write("Введите дату принятия на работу: ");
            //    employees[i].applyDate = new int[dateNumbers];
            //    employees[i].applyDate[0] = int.Parse(ReadLine());
            //    employees[i].applyDate[1] = int.Parse(ReadLine());
            //    employees[i].applyDate[2] = int.Parse(ReadLine());
            //}

            //WriteLine("Имя:\tДолжность:\tЗарплата:\tДата принятия:");
            //foreach (Employee employee in employees)
            //{
            //    WriteLine($"{employee.name}\t{employee.vacancy}\t{employee.salary}\t{employee.applyDate[0]}/{employee.applyDate[1]}/{employee.applyDate[2]}");
            //}

            //Array.Sort(employees);
            //WriteLine("Менеджеры с большей зарплатой, чем средняя зарплата клерков: ");
            //WriteLine("Имя:\tДолжность:\tЗарплата:\tДата принятия:");

            //double averageClerkSalary = 0;
            //int clerkCounter = 0;
            //foreach (Employee employee in employees)
            //{
            //    if (employee.vacancy == Vacancies.Clerk)
            //    {
            //        averageClerkSalary += employee.salary;
            //        clerkCounter++;
            //    }
            //}
            //if (clerkCounter != 0)
            //    averageClerkSalary /= clerkCounter;

            //foreach (Employee employee in employees)
            //{
            //    if (employee.vacancy == Vacancies.Manager && employee.salary > averageClerkSalary)
            //        WriteLine($"{employee.name}\t{employee.vacancy}\t{employee.salary}\t{employee.applyDate[0]}/{employee.applyDate[1]}/{employee.applyDate[2]}");
            //}

            //Array.Sort(employees);
            //WriteLine("Чиновники, принятые на работу позже босса: ");
            //WriteLine("Имя:\tДолжность:\tЗарплата:\tДата принятия:");

            //int dayNumber = 0, monthNumber = 1, yearNumber = 2;
            //int[] bossApplyDate = new int[3];

            //foreach (Employee employee in employees)
            //{
            //    if (employee.vacancy == Vacancies.Boss)
            //    {
            //        bossApplyDate = employee.applyDate;
            //    }
            //}
            //foreach (Employee employee in employees)
            //{
            //    if (employee.applyDate[yearNumber] > bossApplyDate[yearNumber])
            //        WriteLine($"{employee.name}\t{employee.vacancy}\t{employee.salary}\t{employee.applyDate[0]}/{employee.applyDate[1]}/{employee.applyDate[2]}");
            //    else if (employee.applyDate[yearNumber] == bossApplyDate[yearNumber])
            //    {
            //        if (employee.applyDate[monthNumber] > bossApplyDate[monthNumber])
            //            WriteLine($"{employee.name}\t{employee.vacancy}\t{employee.salary}\t{employee.applyDate[0]}/{employee.applyDate[1]}/{employee.applyDate[2]}");
            //        else if (employee.applyDate[monthNumber] == bossApplyDate[monthNumber])
            //        {
            //            if (employee.applyDate[dayNumber] > bossApplyDate[dayNumber])
            //                WriteLine($"{employee.name}\t{employee.vacancy}\t{employee.salary}\t{employee.applyDate[0]}/{employee.applyDate[1]}/{employee.applyDate[2]}");
            //        }
            //    }
            //}



            // 2

            const int MINIMAL_SALARY = 23000;
            const int STUDENTS_COUNT = 5;
            Student[] students = new Student[STUDENTS_COUNT];

            #region inserting
            students[0].fio = "Зубенко Михаил Петрович";
            students[0].group = "SDP-181";
            students[0].averageMark = 1;
            students[0].profitOnFamilyMember = 145000;
            students[0].gender = Genders.Male;
            students[0].studyForm = StudyForm.Full;

            students[1].fio = "Жмышенко Валерий Альбертович";
            students[1].group = "SEP-181";
            students[1].averageMark = 10;
            students[1].profitOnFamilyMember = 145000;
            students[1].gender = Genders.Male;
            students[1].studyForm = StudyForm.Half;

            students[2].fio = "Иванова Елена Владимировна";
            students[2].group = "SMB-181/2";
            students[2].averageMark = 12;
            students[2].profitOnFamilyMember = 145000;
            students[2].gender = Genders.Female;
            students[2].studyForm = StudyForm.Full;

            students[3].fio = "Каратаев Платон Андреевич";
            students[3].group = "SDN-181";
            students[3].averageMark = 12;
            students[3].profitOnFamilyMember = 125000;
            students[3].gender = Genders.Male;
            students[3].studyForm = StudyForm.WeekendCources;

            students[4].fio = "Болконская Мария Николаевна";
            students[4].group = "SMP-181";
            students[4].averageMark = 12;
            students[4].profitOnFamilyMember = 25000;
            students[4].gender = Genders.Female;
            students[4].studyForm = StudyForm.Full;
            #endregion


            WriteLine("Очередь на предоставление общежития:");
            int orderNumber = 1;

            foreach (Student student in students)
            {
                if (student.profitOnFamilyMember <= MINIMAL_SALARY * 2)
                {
                    WriteLine(orderNumber + ". " + student.fio);
                    orderNumber++;
                }
            }

            Array.Sort(students);

            foreach (Student student in students)
            {
                if (student.profitOnFamilyMember > MINIMAL_SALARY * 2)
                {
                    WriteLine(orderNumber + ". " + student.fio);
                    orderNumber++;
                }
            }


            ReadLine();
        }
    }
}
