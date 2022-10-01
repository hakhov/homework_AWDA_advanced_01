using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloads
{
    internal class Point2D
    {
        private (double x, double y) point;
        public Point2D(double x = 0, double y = 0)
        {
            point.x = x;
            point.y = y;
        }

        public void ShowInfo()
        {
            Console.WriteLine(point);
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            Point2D pointt = new();
            pointt.point.x = point1.point.x + point2.point.x;
            pointt.point.y = point1.point.y + point2.point.y;
            return pointt;

        }

        public static Point2D operator ++(Point2D point2D)
        {
            point2D.point.x += 1;
            point2D.point.y += 1;
            return point2D; 
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            Point2D pointt = new();
            pointt.point.x = point1.point.x - point2.point.x;
            pointt.point.y = point1.point.y - point2.point.y;
            return pointt;

        }

        public static Point2D operator /(Point2D point1, Point2D point2)
        {
            Point2D pointt = new();
            if (point2.point.x != 0 && point2.point.y != 0 )
            {
                pointt.point.x = point1.point.x / point2.point.x;
                pointt.point.y = point1.point.y / point2.point.y;
                return pointt;
            }
            else
            {
                pointt.point.x = 0;
                pointt.point.y = 0;
                return pointt;
            }

        }

        public static Point2D operator *(Point2D point1, Point2D point2)
        {
            Point2D pointt = new();
            pointt.point.x = point1.point.x * point2.point.x;
            pointt.point.y = point1.point.y * point2.point.y;
            return pointt;

        }

        public static Point2D operator +(Point2D point1,int x)
        {
            Point2D pointt = new();
            pointt.point.x = point1.point.x + x;
            pointt.point.y = point1.point.y + x;
            return pointt;

        }

        public static Point2D operator *(Point2D point1, int x)
        {
            Point2D pointt = new();
            pointt.point.x = point1.point.x * x;
            pointt.point.y = point1.point.y * x;
            return pointt;

        }
    }
}
