using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class PassengerCar : Car
    {
        public int PassengersCount { get; set; }

        public PassengerCar() : base()
        {

        }

        public PassengerCar(Finish method) : base (method)
        {

        }

        public override void Ride()
        {
            Position -= (PassengersCount * 10);
            base.Ride();
        }
    }
}
