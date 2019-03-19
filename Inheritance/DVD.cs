using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class DVD : Storage
    {
        public double ReadWriteSpeed { get; set; }
        public DVDType Type { get; set; }
        private List<File> files;

        public DVD()
        {
            ReadWriteSpeed = 10;
            Type = DVDType.TwoSided;
            files = new List<File>();
        }

        public override double GetMemoryCapacity()
        {
            return (double)Type;
        }

        public override void CopyFiles(File file)
        {
            double wastedTime = 0;
            if (GetFreeSpace() >= file.Size)
            {
                files.Add(file);
                wastedTime = file.Size / ReadWriteSpeed;
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
            return $"{name} модели {model}: скорость чтения/записи - {ReadWriteSpeed}, объем памяти {(double)Type}Mb ({Type})";
        }
    }
}
