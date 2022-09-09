public class Number2
{
    public int x;
    public int y;
    public Number2(int x,int y)
    {
        this.x = x;
        this.y = y; 
    }
    public Number2(){}
    public void Method()
    {
        Console.WriteLine(x+"\t"+y);
    }
    public static Number2 operator -(Number2 num1,Number2 num2)
    {
        Number2 number = new Number2();
        number.x= num1.x - num2.x;
        number.y= num1.y - num2.y;
        return number;  

    }
    public static Number2 operator *(Number2 num1, Number2 num2)
    {
        Number2 number = new Number2();
        number.x = num1.x * num2.x;
        number.y = num1.y * num2.y;
        return number;

    }
    public static Number2 operator /(Number2 num1, Number2 num2)
    {
        Number2 number = new Number2();
        if(num2.x!=0)
        number.x = num1.x / num2.x;
        if(num2.y!=0)
        number.y = num1.y - num2.y;
        return number;
    }
}