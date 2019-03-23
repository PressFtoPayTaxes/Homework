using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Team
    {
        public Worker[] workers { get; set; }
        public TeamLeader teamLeader { get; set; }
        public Team(int workersCount)
        {
            workers = new Worker[workersCount];
            for (int i = 0; i < workersCount; i++)
            {
                workers[i] = new Worker();
            }
            teamLeader = new TeamLeader();
        }

        public void BuildHouse(House house, ref Dictionary<string, int> report)
        {
            foreach(var worker in workers)
            {
                worker.DoWork(house, ref report);
            }
            teamLeader.DoWork(house, ref report);
        }
    }
}
