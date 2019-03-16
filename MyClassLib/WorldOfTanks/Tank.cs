using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string _name;
        private int _ammunitionLevel;
        private int _armorLevel;
        private int _mobilityLevel;
        private Random _randomNumber = new Random((int)DateTime.Now.Ticks);

        public Tank(string name)
        {
            _name = name;
            _ammunitionLevel = _randomNumber.Next(0, 100);
            _armorLevel = _randomNumber.Next(0, 100);
            _mobilityLevel = _randomNumber.Next(0, 100);
            Thread.Sleep(1);
            
        }

        public static string operator *(Tank tank, Tank enemy)
        {
            int higherCharachteristics = 0;

            try
            {
                if (tank._ammunitionLevel > enemy._ammunitionLevel)
                {
                    higherCharachteristics++;
                }
                if (tank._armorLevel > enemy._armorLevel)
                {
                    higherCharachteristics++;
                }
                if (tank._mobilityLevel > enemy._mobilityLevel)
                {
                    higherCharachteristics++;
                }
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            if (higherCharachteristics >= 2)
            {
                return tank._name;
            }
            else
            {
                return enemy._name;
            }
        }

        public string TankInfo()
        {
            try
            {
                return $"Танк {_name}: боекомплект - {_ammunitionLevel}; броня - {_armorLevel}; маневренность - {_mobilityLevel}";
            }
            catch (System.NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return "Произошло исключение...";
        }


    }
}
