using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Storage
    {
        protected string name;
        protected string model;
        public abstract double GetMemoryCapacity();
        public abstract void CopyFiles(File file);
        public abstract double GetFreeSpace();
        public abstract string GetInfo(); 

    }
}
