using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Console.WriteLine("Количество людей в бригаде, не считая бригадира: ");
            int workersCount = int.Parse(Console.ReadLine());

            Team team = new Team(workersCount);

            Dictionary<string, int> report = new Dictionary<string, int>();

            while (true)
            {
                bool isFinished = false;
                Console.WriteLine("Строим...");
                team.BuildHouse(house, ref report);

                Console.WriteLine("Отчёт о постройке дома:");

                foreach (var part in report)
                {
                    Console.WriteLine($"{part.Key}: {part.Value}%");
                }

                Console.WriteLine();

                foreach (var part in report)
                {
                    isFinished = true;
                    if (part.Value < 100)
                    {
                        isFinished = false;
                        break;
                    }
                }

                if (isFinished == true)
                    break;

                Console.WriteLine("Нажмите любую кнопку, чтобы перейти к следующему этапу: ");
                Console.ReadLine();
            }

            Console.WriteLine("Дом построен!!!");

            Console.WriteLine(@"  ____||____");
            Console.WriteLine(@" ///////////\");
            Console.WriteLine(@"///////////  \");
            Console.WriteLine(@"|    _    |  |");
            Console.WriteLine(@"|[] | | []|[]|");
            Console.WriteLine(@"|   | |   |  |");

            Console.ReadLine();
        }
    }
}
