using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Worker : IWorker
    {
        public void DoWork(House house, ref Dictionary<string, int> report)
        {
            if (house.basement.Progress < 100)
            {
                house.basement.Progress += 10;
                return;
            }

            for (int i = 0; i < house.walls.Count(); i++)
            {
                if (house.walls[i].Progress < 100)
                {
                    house.walls[i].Progress += 10;
                    return;
                } 
            }

            if (house.door.Progress < 100)
            {
                house.door.Progress += 10;
                return;
            }

            for (int i = 0; i < house.windows.Count(); i++)
            {
                if (house.windows[i].Progress < 100)
                {
                    house.windows[i].Progress += 10;
                    return;
                }
            }

            if (house.roof.Progress < 100)
            {
                house.roof.Progress += 10;
            }
        }

    }
}
