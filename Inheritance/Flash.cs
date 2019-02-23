using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Flash : Storage
    {
        public double UsbThreeSpeed { get; set; }
        public double Capacity { get; set; }
        private List<File> files;

        public Flash()
        {
            UsbThreeSpeed = 600;
            Capacity = 8000;
            files = new List<File>();
        }
        public override double GetMemoryCapacity()
        {
            return Capacity;
        }

        public override void CopyFiles(File file)
        {
            double wastedTime = 0;
            if (GetFreeSpace() >= file.Size)
            {
                files.Add(file);
                wastedTime = file.Size / UsbThreeSpeed;
            }
            else
                Console.WriteLine("На носителе недостаточно места для копирования файла");
            Console.WriteLine("Копирование заняло " + wastedTime + " секунд");
        }

        public override double GetFreeSpace()
        {
            double occupiedSpace = 0;
            foreach (File file in files)
            {
                occupiedSpace += file.Size;
            }

            return GetMemoryCapacity() - occupiedSpace;
        }
        public override string GetInfo()
        {
            return $"{name} модели {model}: скорость USB 3.0 - {UsbThreeSpeed}, объем памяти {Capacity}Mb";
        }
    }
}
