using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;

namespace TanksFight
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANKS_COUNT = 5;
            Tank[] t34Tanks = new Tank[TANKS_COUNT];
            Tank[] panteraTanks = new Tank[TANKS_COUNT];

            for (int i = 0; i < TANKS_COUNT; i++)
            {
                t34Tanks[i] = new Tank("T-34 #" + string.Concat(i + 1));
                panteraTanks[i] = new Tank("Pantera #" + string.Concat(i + 1));
            }

            for (int i = 0; i < TANKS_COUNT; i++)
            {
                try
                {
                    Console.WriteLine(t34Tanks[i].TankInfo());
                    Console.WriteLine("\t\t\t\tVS");
                    Console.WriteLine(panteraTanks[i].TankInfo());
                    Console.WriteLine("\t\t\tПобедитель: " + (t34Tanks[i] * panteraTanks[i]) + "\n");
                }
                catch (System.NullReferenceException exception)
                {
                    Console.WriteLine(exception.Message);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
