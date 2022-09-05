using homework_AWDA_advanced_01;



Console.Write("Select array size: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];

Console.Write("\nFill the array: 0.Automat 1.Manual   :");

Select: int choose = int.Parse(Console.ReadLine());

switch (choose)
{
    case 0:
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 100);
        }
        break;
    case 1:

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter " + (i + 1) + " number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        break;

    default:
        Console.WriteLine("Wrong command");
        goto Select;
}

Methods.Print(numbers);

Console.Write("\nChoose the method: 1.Max 2.Min 3.Sum 4.Prime 5.Sort  : ");

Select2: choose = int.Parse(Console.ReadLine());

switch (choose)
{
    case 1:
        Console.WriteLine("Max number: " + Methods.Max(numbers));
        break;
    case 2:
        Console.WriteLine("Min number: " + Methods.Min(numbers));
        break;
    case 3:
        Console.WriteLine("Sum of all numbers: " + Methods.Sum(numbers));

        break;
    case 4:
        Console.Write("Prime numbers: ");
        foreach (var item in Methods.Prime(numbers))
        {
            Console.Write(item + ", ");
        }
        break;
    case 5:
        Console.Write("Sorted array: ");
        Methods.Print(Methods.Sort(numbers));

        break;
    default:
        Console.WriteLine("Wrong command");
        goto Select2;

}



Console.WriteLine(Fibonacci.FibonacciMethod(100));



