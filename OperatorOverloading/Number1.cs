public class Number1
{
    private int xx;
    private int yy;
    public Number1()
    {

    }
    public Number1(int x,int y)
    {
        this.xx = x;
        this.yy = y;
    }
    public void Method()
    {
        Console.WriteLine(xx + "\t" + yy);
    }
    public static Number2 operator -(Number1 number1,Number2 number2)
    {
        Number2 number = new Number2();
        number.x = number1.xx - number2.x;
        number.y = number1.yy - number2.y;
        return number;
    }


}