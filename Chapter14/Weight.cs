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
            SetKilo(kilo);
            SetGram(gram);

        }

        public Weight(int totalGram)
        {
            SetGram(totalGram % 1000);

            SetKilo(totalGram / 1000);



        }


    }
}
