using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionInClasses
{
    public partial class Plane
    {
        private string _model;
        private double _velocity;
        private double _wingspan;
        private int _places;
        private bool _isMilitary;

        static int countOfPlanes;
        static double sumOfVelocities;
        static double averageVelocity;

        public Plane()
        {
            countOfPlanes++;
            SetToZero();
        }

        public Plane(string model, double velocity, double wingspan, int places)
        {
            countOfPlanes++;
            SetModel(model);
            SetVelocity(velocity);
            SetWingspan(wingspan);
            SetPlaces(places);
            if (places <= 4)
            {
                _isMilitary = true;
            }
            else
            {
                _isMilitary = false;
            }

        }

        static Plane()
        {
            averageVelocity = 0;
            sumOfVelocities = 0;
            countOfPlanes = 0;
        }

        #region Access
        public string GetModel()
        {
            return _model;
        }
        public void SetModel(string model)
        {
            _model = model;
        }

        public double GetVelocity()
        {
            return _velocity;
        }
        public void SetVelocity(double velocity)
        {
            sumOfVelocities -= _velocity;
            _velocity = velocity;
            sumOfVelocities += _velocity;
            averageVelocity = sumOfVelocities / countOfPlanes;
        }

        public double GetWingspan()
        {
            return _wingspan;
        }
        public void SetWingspan(double wingspan)
        {
            _wingspan = wingspan;
        }

        public int GetPlaces()
        {
            return _places;
        }
        public void SetPlaces(int places)
        {
            _places = places;
        }

        public bool GetIsMilitary()
        {
            return _isMilitary;
        }
        #endregion

        public void TurnToMilitary()
        {
            int maximumPlaces = 4;
            if (!_isMilitary)
            {
                _places = maximumPlaces;
                _isMilitary = true;
            }
        }

        public void SetToZero()
        {
            sumOfVelocities -= _velocity;
            _model = "Plane";
            _velocity = 0;
            _wingspan = 0;
            _places = 0;
            _isMilitary = false;
            averageVelocity = sumOfVelocities / countOfPlanes;
        }

        public void Default()
        {
            sumOfVelocities -= _velocity;
            string defaultModel = "Boeing 787 Dreamliner";
            double defaultVelocity = 962;
            double defaultWingspan = 60.2;
            int defaultPlaces = 250;
            bool defaultIsMilitary = false;

            _model = defaultModel;
            _velocity = defaultVelocity;
            _wingspan = defaultWingspan;
            _places = defaultPlaces;
            _isMilitary = defaultIsMilitary;
            sumOfVelocities += _velocity;
            averageVelocity = sumOfVelocities / countOfPlanes; 
        }

        public void CopyModel(ref string model)
        {
            model = _model;
        }

    }
}
