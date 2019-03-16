using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static double AllStoragesCapacity(Storage[] storages)
        {
            double allStoragesCapacity = 0;
            foreach(Storage storage in storages)
            {
                allStoragesCapacity += storage.GetMemoryCapacity();
            }
            return allStoragesCapacity;
        }
        static void Main(string[] args)
        {
            const int STORAGES_COUNT = 3;
            Storage[] storages = new Storage[STORAGES_COUNT];
            storages[0] = new Flash();
            storages[1] = new DVD();
            storages[2] = new HDD();

            Console.WriteLine("Количество памяти во всех носителях: " + AllStoragesCapacity(storages));

            File someFile = new File();
            someFile.SomeData = "WinRAR-Archive";
            someFile.Size = 2000;

            storages[0].CopyFiles(someFile);
            storages[1].CopyFiles(someFile);
            storages[2].CopyFiles(someFile);


            Console.ReadLine();
        }
    }
}
