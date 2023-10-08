using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LebedevIV.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res =  x + Math.Pow((x + 1 / x - 1), x);
            } else if (x == 0) {
                res = 1 + Math.Cos(Math.Sqrt(x + 1));
            } else if (-16 < x && x < 2)
            {
                res = 7 + 5 / Math.Pow(x, 2);
            } else if(x < -16)
            {
                res = x + 10 * x - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}
