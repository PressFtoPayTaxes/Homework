using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractic
{
    class Money
    {
        private int _denominationOfBanknote;
        private int _countOfBanknotes;

        public Money()
        {

        }

        public Money(int denominationOfBanknote, int countOfBanknotes)
        {
            _denominationOfBanknote = denominationOfBanknote;
            _countOfBanknotes = countOfBanknotes;
        }

        public void Print()
        {
            Console.WriteLine("Номинал купюры: " + _denominationOfBanknote);
            Console.WriteLine("Количетсво купюр: " + _countOfBanknotes);
        }

        public bool IsEnough(int cost)
        {
            if (_denominationOfBanknote * _countOfBanknotes > cost)
            {
                return true;
            }
            return false;
        }

        public int HowMuch(int costOfOne)
        {
            return _countOfBanknotes * _denominationOfBanknote / costOfOne;
        }

        public int DenominationOfBanknote
        {
            get
            {
                return _denominationOfBanknote;
            }
            set
            {
                _denominationOfBanknote = value;   
            }
        }

        public int CountOfBanknotes
        {
            get
            {
                return _countOfBanknotes;
            }
            set
            {
                _countOfBanknotes = value;
            }
        }

        public int Sum
        {
            get
            {
                return _countOfBanknotes * _denominationOfBanknote;
            }
        }



    }
}
