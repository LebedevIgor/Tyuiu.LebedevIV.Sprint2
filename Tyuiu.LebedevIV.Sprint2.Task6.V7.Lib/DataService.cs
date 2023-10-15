using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LebedevIV.Sprint2.Task6.V7.Lib
{
    public class DataService : ISprint2Task6V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int totalDays = (n * 30) + 2;

            int monthNumber = (totalDays / 30) + 1;

            string monthName;
            switch (monthNumber)
            {
                case 1:
                    monthName = "январь";
                    break;
                case 2:
                    monthName = "февраль";
                    break;
                case 3:
                    monthName = "март";
                    break;
                case 4:
                    monthName = "апрель";
                    break;
                case 5:
                    monthName = "май";
                    break;
                case 6:
                    monthName = "июнь";
                    break;
                case 7:
                    monthName = "июль";
                    break;
                case 8:
                    monthName = "август";
                    break;
                case 9:
                    monthName = "сентябрь";
                    break;
                case 10:
                    monthName = "октябрь";
                    break;
                case 11:
                    monthName = "ноябрь";
                    break;
                case 12:
                    monthName = "декабрь";
                    break;
                default:
                    monthName = "недопустимый номер месяца";
                    break;
            }

            return monthName;
        }
    }
}
