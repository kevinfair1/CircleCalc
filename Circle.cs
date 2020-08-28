using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CsharpWeek11CircleCalc
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                if (radius < 0)
                    radius = radius * -1;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getCircumference()
        {
            return 2 * Math.PI * radius;
        }
    }

}