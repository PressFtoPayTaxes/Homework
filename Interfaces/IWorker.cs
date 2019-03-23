using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IWorker
    {
        void DoWork(House house, ref Dictionary<string, int> report);
    }
}
