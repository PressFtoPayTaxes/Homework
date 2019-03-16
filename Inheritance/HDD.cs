using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class HDD : Storage
    {
        public double UsbTwoSpeed { get; set; }
        public int SectionsCount { get; set; }
        public double SectionsCapacity { get; set; }
        private List<File> files;

        public HDD()
        {
            UsbTwoSpeed = 480;
            SectionsCount = 2;
            SectionsCapacity = 4000;
            files = new List<File>();
        }

        public override double GetMemoryCapacity()
        {
            return SectionsCount * SectionsCapacity;
        }

        public override void CopyFiles(File file)
        {
            double wastedTime = 0;
            if (GetFreeSpace() >= file.Size)
            {
                files.Add(file);
                wastedTime = file.Size / UsbTwoSpeed;
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
            return $"{name} модели {model}: скорость USB 2.0 - {UsbTwoSpeed}, {SectionsCount} разделов по {SectionsCapacity}Mb";
        }
    }
}
