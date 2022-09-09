using Homework6;

class Program
{
    static void Main(string[] args)
    {
        Point2D point1 = new Point2D(5, 6);
        Point2D point2 = new Point2D(1, -3);

        //point1.ShowInfo();
        //(++point1).ShowInfo();
        //point1.ShowInfo();

        //point2.ShowInfo();
        //(--point2).ShowInfo();
        //point2.ShowInfo();

        point1.ShowInfo();
        point1++.ShowInfo();
        point1.ShowInfo();

        point1.ShowInfo();
        point1--.ShowInfo();
        point1.ShowInfo();
    }
}
