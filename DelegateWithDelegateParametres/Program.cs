ShowCalculusResult show = new ShowCalculusResult();
Calculus op = new Calculus();


DelgateWithDelegateParametres del = new DelgateWithDelegateParametres(show.PrintAddResult);
del.Invoke(op.Add, PrintNumber);




static void PrintNumber(double number)
{
    Console.WriteLine(number);
}
