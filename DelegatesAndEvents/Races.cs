using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void Ride();
    public class Races
    {
        public event Ride NewStep;
        public List<Car> Participants { get; set; }
        public int RaceLength { get; set; }

        public Races(List<Car> cars)
        {
            Participants = cars;
            foreach(var participant in Participants)
            {
                NewStep += participant.Ride;
            }
            RaceLength = 1000;
        }

        public Races(List<Car> cars, int raceLength)
        {
            Participants = cars;
            foreach (var participant in Participants)
            {
                NewStep += participant.Ride;
            }
            RaceLength = raceLength;
        }

        public void Go()
        {
            NewStep();
            foreach(var participant in Participants)
            {
                if (participant.Position >= RaceLength)
                {
                    participant.IsFinished = true;
                }
            }
            for(int i = 0; i < Participants.Count; i++)
            {
                if(Participants[i].Position > RaceLength / 20 && !Participants[i].FirstMarkPassed)
                {
                    Car participant = Participants[i];
                    ChangeVelocity(ref participant);
                    participant.FirstMarkPassed = true;
                }
                if (Participants[i].Position > RaceLength / 40 && !Participants[i].SecondMarkPassed)
                {
                    Car participant = Participants[i];
                    ChangeVelocity(ref participant);
                    participant.SecondMarkPassed = true;
                }
                if (Participants[i].Position > RaceLength / 60 && !Participants[i].ThirdMarkPassed)
                {
                    Car participant = Participants[i];
                    ChangeVelocity(ref participant);
                    participant.ThirdMarkPassed = true;
                }
                if (Participants[i].Position > RaceLength / 80 && !Participants[i].ForthMarkPassed)
                {
                    Car participant = Participants[i];
                    ChangeVelocity(ref participant);
                    participant.ForthMarkPassed = true;
                }
            }

        }

        public void ChangeVelocity(ref Car car)
        {
            Random random = new Random();
            int velocity = random.Next(-20, 20);
            car.Velocity += velocity;
        }

    }
}
