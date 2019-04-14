using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Truck : Car
    {
        public double CargoMass { get; set; }

        public Truck() : base()
        {

        }

        public Truck(Finish method) : base (method)
        {

        }

        public override void Ride()
        {
            Position -= (int)(CargoMass / 1000);
            base.Ride();
        }
    }
}
