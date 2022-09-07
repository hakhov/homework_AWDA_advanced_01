using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloads
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public Point2D()
        {

        }
        public void ShowInfo()
        {
            Console.WriteLine(_x + "\t" + _y);
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1._x + point2._x;
            point._y = point1._y + point2._y;

            return point;
        }
        public static Point2D operator +(int point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1 + point2._x;
            point._y = point1 + point2._y;

            return point;
        }

        public static Point2D operator +(Point2D point1, int point2)
        {
            Point2D point = new();
            point._x = point1._x + point2;
            point._y = point1._y + point2;

            return point;
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1._x - point2._x;
            point._y = point1._y - point2._y;

            return point;
        }

        public static Point2D operator -(int point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1 - point2._x;
            point._y = point1 - point2._y;

            return point;
        }

        public static Point2D operator -(Point2D point1, int point2)
        {
            Point2D point = new();
            point._x = point1._x - point2;
            point._y = point1._y - point2;

            return point;
        }


        public static Point2D operator *(Point2D point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1._x * point2._x;
            point._y = point1._y * point2._y;

            return point;
        }

        public static Point2D operator *(int point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1 * point2._x;
            point._y = point1 * point2._y;

            return point;
        }

        public static Point2D operator *(Point2D point1, int point2)
        {
            Point2D point = new();
            point._x = point1._x * point2;
            point._y = point1._y * point2;

            return point;
        }

        public static Point2D operator /(Point2D point1, Point2D point2)
        {
            Point2D point = new();

            point._x = point1._x / point2._x;
            point._y = point1._y / point2._y;

            return point;
        }

        public static Point2D operator /(int point1, Point2D point2)
        {
            Point2D point = new();
            point._x = point1 / point2._x;
            point._y = point1 / point2._y;

            return point;
        }

        public static Point2D operator /(Point2D point1, int point2)
        {
            Point2D point = new();
            point._x = point1._x / point2;
            point._y = point1._y / point2;

            return point;
        }
    }
}

