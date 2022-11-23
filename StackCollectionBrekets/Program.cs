char[] arr = new char[6] { '{', '[', '(', ')', ']','}'};

Stack<char> stack = new Stack<char> { };
stack.Push(arr[0]);
stack.Push(arr[1]);
stack.Push(arr[2]);

bool answer = false;
for (int i = 3; i < 6; i++)
{

    if ((arr[i] == ')' && stack.Pop() == '(') || (arr[i] == '}' && stack.Pop() == '{') || (arr[i] == ']' && stack.Pop() == '['))
        answer = !answer;
    else
        break;
}
Console.WriteLine(answer);
