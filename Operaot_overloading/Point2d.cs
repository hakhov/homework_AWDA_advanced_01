namespace Operaot_overloading
{
    public class Point2d
    {
        public int year { get; set; }
        public int day { get; set; }

        public static Point2d operator - (Point2d point1, Point2d point2)
        {
            Point2d point3 = new();
            point3.day = point1.day - point2.day;
            point3.year = point1.year - point2.year;

            return point3;
        }

        public static Point2d operator /(Point2d point2D, Point2d point2D2)
        {
            Point2d point2d1 = new();
            point2d1.year = point2D.year / point2D2.year;
            point2d1.day = point2D.day / point2D2.day;
            return point2d1;
        }

        public static Point2d operator *(Point2d point2D, Point2d point2D2)
        {
            Point2d point2d1 = new();
            point2d1.year = point2D.year * point2D2.year;
            point2d1.day = point2D.day * point2D2.day;
            return point2d1;
        }


    }
}