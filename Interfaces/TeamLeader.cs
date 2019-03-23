using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class TeamLeader : IWorker
    {
        public void DoWork(House house, ref Dictionary<string, int> report)
        {
            report.Clear();

            report.Add("Фундамент", house.basement.Progress);

            for (int i = 0; i < house.walls.Count(); i++)
                report.Add("Стена " + string.Concat(i + 1), house.walls[i].Progress);

            report.Add("Дверь", house.door.Progress);

            for (int i = 0; i < house.windows.Count(); i++)
                report.Add("Окно " + string.Concat(i + 1), house.windows[i].Progress);

            report.Add("Крыша", house.roof.Progress);
        }

    }
}
