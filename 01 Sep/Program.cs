// Square Equals

Console.WriteLine(GetArr(1, -6, 5));

static string GetArr(double a, double b, double c)
{
    double d= b*b-4*a*c;
    if (d >= 0)
    {
        double x1 = (-b - Math.Sqrt(d)) / (2 * a);
        double x2 = (-b + Math.Sqrt(d)) / (2 * a);
        string X1= x1.ToString();
        string X2= x2.ToString();
        string str = "X1="+X1 + ", "+"X2=" + X2;
        return str;

    }
    else
        return "Error";
}