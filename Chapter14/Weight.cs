using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter14
{
    public class Weight
    {
        private int _kilo;



        public int GetKilo()
        {
            return _kilo;
        }

        public void SetKilo(int kilo)
        {
            _kilo = kilo;
        }


        private int _gram;

        public int GetGram()
        {
            return _gram;
        }

        public void SetGram(int gram)
        {

            _gram = gram;
        }



        public Weight()
        {
            SetKilo(0);
            SetGram(0);

        }

        public Weight(int kilo, int gram)
        {
            this._kilo = kilo;
            this._gram = gram;


        }

        public Weight(int totalGram)
        {
            this._kilo = totalGram / 1000;
            this._gram = totalGram % 1000;

        }

        public void Add(Weight other)
        {
            int totalGram = 1000 * (this._kilo + other._kilo) +
                            this._gram +
                            other._gram;

            Weight tmp = new Weight(totalGram);
            this._kilo = tmp.GetKilo();
            this._gram = tmp.GetGram();
        }

        public bool Less(Weight other)
        {
            int meGram = 1000 * this._kilo + this._gram;
            int otherGram = 1000 * other._kilo + other._gram;

            return meGram < otherGram;



            //if (this._kilo < other._kilo)
            //{
            //    return true;
            //}
            //else if (this._kilo == other._kilo)
            //{
            //    return this._gram < other._gram;
            //}
            //else
            //{
            //    return false;
            //}



        }
    }
}
