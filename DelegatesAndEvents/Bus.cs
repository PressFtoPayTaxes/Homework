using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Bus : Car
    {
        public double Length { get; set; }

        public Bus() : base()
        {

        }

        public Bus(Finish method) : base (method)
        {

        }

        public override void Ride()
        {
            Position -= (int)(Length / 2);
            base.Ride();
        }
    }
}
