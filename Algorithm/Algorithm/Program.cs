//int[] arr = { 5, 4, 1, 213, 48, 4, 1, 21, 0, -2 };
//Sort.BubbleSort(arr);

//Console.WriteLine($"Sorted:{string.Join(",", arr)}");

List<string> list = new List<string> { "({[]})", "][(]}})(" };

foreach (var barcketsList in list)

{
    string expression = barcketsList;
    Stack<char> stack = new Stack<char>();
    char[] symbols = expression.ToCharArray();
    if (symbols.Length == 0)
    {
        break;
    }
    bool flagPrint = false;
    for (int start = 0; start < symbols.Count(); start++)
    {
        char temp = symbols[start];
        if (temp == '[' || temp == '{' || temp == '(')
        {
            stack.Push(temp);
        }
        else
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("NO");
                flagPrint = true;
                break;

            }
            char top = stack.Peek();
            if (temp == ']')
            {
                if (top != '[')
                {
                    break;
                }
                stack.Pop();
            }
            else if (temp == '}')
            {
                if (top != '{')
                {

                    break;
                }
                stack.Pop();
            }
            else
            {
                if (top != '(')
                {

                    break;
                }
                stack.Pop();
            }
        }
    }
    if (!stack.Any() && !flagPrint)
    {
        Console.WriteLine("YES");
    }
    else if (!flagPrint)
    {
        Console.WriteLine("NO");
    }
}