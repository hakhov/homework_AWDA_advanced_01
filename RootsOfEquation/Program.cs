//With tuple
Console.Write("a=");
int a=int.Parse(Console.ReadLine());
Console.Write("b=");
int b=int.Parse(Console.ReadLine());
Console.Write("c=");
int c=int.Parse(Console.ReadLine());

Console.WriteLine(GetRoots(a,b,c));

static (double,double) GetRoots(int a,int b,int c)
{
    (double, double) answer = (0.0, 0.0);
    int d = b * b - 4 * a * c;
    if (d > 0)
    {
        answer.Item1 = (-b + Math.Sqrt(d)) / (2 * a);
        answer.Item2 = (-b - Math.Sqrt(d)) / (2 * a);
    }
    else if (d == 0)
    {
        answer.Item1 = -b / (2 * a);
        answer.Item2 = answer.Item1;
    }
    else
    {
        throw new Exception();
    }
    return answer;
}

