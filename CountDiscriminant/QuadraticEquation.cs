namespace CountDiscriminant
{
    public class QuadraticEquation
    {
        public (double,double) GetSolution(int a,int b, int c,ref double x, ref double y)
        {
            double discriminant = Math.Pow(b, 2) - 4 * c * a;
            (double, double) sol = (x, y);

            if (discriminant>0)
            {
                x = -b + Math.Sqrt(discriminant)/(2*a);
                y = -b - Math.Sqrt(discriminant)/(2*a);
            }
            else if (discriminant == 0)
            {
                x = -b/(2*a);
                y = x;
            }
            else
            {
                x = double.NaN;
                y = double.NaN;
            }

            return (x,y);
        }
    }
}