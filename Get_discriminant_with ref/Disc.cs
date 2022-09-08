namespace Get_discriminant_with_ref
{
    public class Disc
    {
        public static (double, double) GetX(ref double a, ref double b, ref double c)
        {
            double x1 = 0, x2 = 0, x = 0;
            double D = b * b - 4 * a * c;
            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            else
                throw new Exception("The discriminant is negative");
            return (x1, x2);

        }
    }
}
