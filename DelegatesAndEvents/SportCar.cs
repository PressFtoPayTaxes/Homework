using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class SportCar : Car
    {
        public int BonusSpeed { get; set; }

        public SportCar() : base()
        {

        }

        public SportCar(Finish method) : base (method)
        {
                
        }

        public override void Ride()
        {
            Position += BonusSpeed;
            base.Ride();
        }
    }
}
