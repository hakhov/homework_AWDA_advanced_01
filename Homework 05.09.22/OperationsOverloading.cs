
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsOverloading
{
    internal class Point2D
    {
        public double x;
        public double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"x= {x},y={y}");
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            Point2D result = new Point2D();
            result.x = point1.x + point2.x;
            result.y = point1.y + point2.y;

            return result;
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            Point2D result = new Point2D();
            result.x = point1.x - point2.x;
            result.y = point1.y - point2.y;

            return result;
        }

        public static Point2D operator *(Point2D point1, Point2D point2)
        {
            Point2D result = new Point2D();
            result.x = point1.x * point2.x;
            result.y = point1.y * point2.y;

            return result;
        }

        public static Point2D operator /(Point2D point1, Point2D point2)
        {
            Point2D result = new Point2D();
            result.x = point1.x / point2.x;
            result.y = point1.y / point2.y;

            return result;
        }

        public static Point2D operator ++(Point2D point1)
        {
            point1.x++;
            point1.y++;
            return point1;
        }

        public static Point2D operator --(Point2D point1)
        {
            --point1.x;
            --point1.y;
            return point1;
        }
        //C# ++ ev -- operatorneri menak mi versian kareli a irakanacnel
        //pre increment u decrement menak karanq miayn anenq,post versian chi linum classneri hamar overload anel

    }
}
