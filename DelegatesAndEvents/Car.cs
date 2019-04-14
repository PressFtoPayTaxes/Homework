using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void Finish();
    public abstract class Car
    {
        public event Finish Finish;
        public string Model { get; set; }
        public int Velocity { get; set; }
        public double Mass { get; set; }
        public int Position { get; set; }
        public bool IsFinished { get; set; }
        public bool FirstMarkPassed { get; set; }
        public bool SecondMarkPassed { get; set; }
        public bool ThirdMarkPassed { get; set; }
        public bool ForthMarkPassed { get; set; }


        public Car()
        {
            FirstMarkPassed = false;
            SecondMarkPassed = false;
            ThirdMarkPassed = false;
            ForthMarkPassed = false;
            IsFinished = false;
            Finish += () => { Console.WriteLine("Победила машина " + Model); };
        }

        public Car(Finish method)
        {
            FirstMarkPassed = false;
            SecondMarkPassed = false;
            ThirdMarkPassed = false;
            ForthMarkPassed = false;
            IsFinished = false;
            Finish += method;
        }

        public virtual void Ride()
        {
            Position += Velocity - (int)(Mass / 100);
        }

        public bool CheckFinish()
        {
            if (IsFinished)
            {
                Finish();
                return true;
            }
            return false;
        }
    }
}
