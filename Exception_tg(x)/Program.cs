using System.Security.Cryptography.X509Certificates;

Console.WriteLine("tg(PI/x) =  ? ");
Console.WriteLine("Please enter x:)");
Console.Write("x = ");
int x = int.Parse(Console.ReadLine());
try
{
    if (x == 2 || x == -2 || x == 0)
    {
        switch (x)
        {
            case 2 or -2:
                throw new TanException();
                break;
            case 0:
                throw new DivideByZeroException();
                break;
            default:
                throw new Exception();
        }
    }
    else Console.WriteLine(Math.Tan(Math.PI / x));
}
catch (TanException t)
{
    Console.WriteLine(t.Message);
}
catch (DivideByZeroException e)
{
    Console.Write("x can not be 0 - ");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
class TanException : Exception
{
    public TanException()
    {
        Console.WriteLine("Tanges does not exit at 90  and 270 degrees");
    }
}

