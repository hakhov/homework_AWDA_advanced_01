using System;
namespace Homework_6
{
    public class Point2D
    {
        private int _x;
        private int _y;
        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Point2D() { }
        public void ShowInfo()
        {
            Console.WriteLine(_x + "  " + _y);
        }
        public static Point2D operator ++(Point2D point2d)
        {
            Point2D result = new Point2D();
            result._x = point2d._x + 1;
            result._y = point2d._y + 1;
            return result;
        }
        public static Point2D operator --(Point2D point2d)
        {
            Point2D result = new Point2D();
            result._x = point2d._x - 1;
            result._y = point2d._y - 1;
            return result;
        }
    }
}



