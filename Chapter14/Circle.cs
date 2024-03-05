using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    public class Circle
    {
        #region Fields

        private int _radius;
        private string _color;

        #endregion

        #region Accessors

        public int GetRadius()
        {

            return this._radius;
        }
        public void SetRadius(int radius)
        {

            this._radius = radius;
        }

        public string GetColor()
        {

            return this._color;
        }
        public void SetColor(string color)
        {

            this._color = color;
        }

        #endregion

        #region Constractors

        public Circle()
        {

        }
        public Circle(int radius, string color)
        {
            //_radius = radius;
            //_color = color;

            SetRadius(radius);
            SetColor(color);



        }

        #endregion

        #region Methods

        public double GetArea()
        {
            return Math.PI * Math.Pow(GetRadius(), 2);

        }
        public static double GetPI()
        {
            return Math.PI;

        }


        public override string ToString()
        {
            return $"Radius:{GetRadius()}, Color{GetColor()}";
        }

        #endregion
    }
}

