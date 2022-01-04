using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19___WpfApp.Models
{
    //Класс из урока 12 (основы C++)
    static class Circle
    {
        public static double LengthCircle(double r)
        {
            double res = 0;
            res = 2 * Math.PI * r;
            return res;
        }
        public static double SquareCircle(double r)
        {
            double res = 0;
            res = Math.PI * Math.Pow(r, 2);
            return res;
        }
        public static void ComparPointCircle(int pointX, int pointY, double circleR, int centrPointCircleX = 0, int centrPointCircleY = 0)
        {
            //Определяем длину от центра окружности до точки
            double L = Math.Sqrt(Math.Pow((centrPointCircleX - pointX), 2) + Math.Pow((centrPointCircleY - pointY), 2));
            string str = "";
            if (L <= circleR)
            {
                str = "принадлежит";
            }
            else
            {
                str = "не принадлежит";
            }

            Console.WriteLine(
                "Точка с координатами ({0};{1}) {4} окружности с радиусом {5:f2} и с центром в точке ({2};{3})",
                pointX, pointY, centrPointCircleX, centrPointCircleY, str, circleR);
        }
    }
}
