using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Car sportCar = new SportCar();
            sportCar.Model = "Infiniti Q60";
            sportCar.Velocity = 100;
            sportCar.Mass = 1700;
            (sportCar as SportCar).BonusSpeed = 20;

            Car truck = new Truck();
            truck.Model = "КАМАЗ 6х4";
            truck.Velocity = 45;
            truck.Mass = 2000;
            (truck as Truck).CargoMass = 0;

            Car passengerCar = new PassengerCar();
            passengerCar.Model = "Proton Persona";
            passengerCar.Velocity = 95;
            passengerCar.Mass = 1105;
            (passengerCar as PassengerCar).PassengersCount = 1;

            List<Car> cars = new List<Car> { sportCar, passengerCar, truck };

            Races manager = new Races(cars);
            Console.WriteLine("Гонка начинается! Длина трассы: " + manager.RaceLength);
            while (true)
            {
                bool isStop = false;
                manager.Go();
                foreach (var car in manager.Participants)
                {
                    Console.WriteLine($"\n{car.Model} находится на позиции {car.Position}");
                    if (car.CheckFinish())
                    {
                        isStop = true;
                        break;
                    }
                }
                if (isStop)
                    break;
                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadLine();

            }
        }
    }
}
