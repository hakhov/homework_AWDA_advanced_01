namespace Brackets_in_Stack_02
{
    public class Brackets_Class
    {
        public void MyMethod(string? txt)
        {
            char[] chtxt = txt.ToCharArray();
            Stack<char> stack = new Stack<char>();
            char top = ' ';
            for (int i = 0; i < chtxt.Length; i++)
            { 
                if (chtxt[i] == '[' || chtxt[i] == '{' || chtxt[i] == '(')
                {
                    stack.Push(chtxt[i]);
                    top = stack.Peek();
                }
                if (chtxt[i] == ']' && top == '[' || chtxt[i] == '}' && top == '{' || chtxt[i] == ')' && top == '(')
                {   stack.Pop();
                    if(stack.Count != 0)
                     top = stack.Peek();
                }

               else if (chtxt[i] == ']' && top != '[' || chtxt[i] == '}' && top != '{' || chtxt[i] == ')' && top != '(')
                { stack.Push(chtxt[i]); }
            }
            if (stack.Count == 0)
                Console.WriteLine(true);
            if (stack.Count % 2 != 0)
                Console.WriteLine(false);

            if (stack.Count!=0 && stack.Count % 2 == 0)
            {
                int c1 = 0, c2 = 0, c3 = 0;
                foreach (char ch in stack)
                {
                    switch (ch)
                    {
                        case '[':
                            c1++;
                            break;
                        case ']':
                            c1--;
                            break;
                        case '(':
                            c2++;
                            break;
                        case ')':
                            c2--;
                            break;
                        case '{':
                            c3++;
                            break;
                        case '}':
                            c3--;
                            break;
                    }
                }
                if (c1 == c2 && c2 == c3 && c1 == 0)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);
            }
        }
    }
}

