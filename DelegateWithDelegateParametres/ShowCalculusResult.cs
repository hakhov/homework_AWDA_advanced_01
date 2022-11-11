public delegate double MathOperation(double x, double y);
public delegate void SomeAction(double number);


public delegate void DelgateWithDelegateParametres(MathOperation op, SomeAction action);


public class ShowCalculusResult
{
    public void PrintAddResult(MathOperation op, SomeAction printing)
    {
        Console.Write("x=");
        double x = 0;
        double y = 0;
        string? input1 = Console.ReadLine();
        while (true)
        {
            if (!double.TryParse(input1, out x))
            {
                Console.Write("your input is not number,try again");
            }
            else
            {
                break;
            }
        }

        Console.Write("y=");
        string? input2 = Console.ReadLine();
        while (true)
        {
            if (!double.TryParse(input2, out y))
            {
                Console.WriteLine("your input is not number,try again");
            }
            else
            {
                break;
            }
        }



        double result = op.Invoke(x, y);
        printing(result);

    }
}
