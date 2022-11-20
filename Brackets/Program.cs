using System;
using System.Collections;

Stack<char> chars = new Stack<char>();
char[] temp = { '{', '[', '(', ')', ']', '}', '[', ']' };
bool check = false;
if (temp[0] == '}' || temp[0] == ']' || temp[0] == ')' || temp.Length % 2 == 1)
{
    check = false;

}
else
{
    for (int i = 0; i < temp.Length; i++)
    {
        if (temp[i] == '{' || temp[i] == '[' || temp[i] == '(')
        {
            chars.Push(temp[i]);
        }
        else
        {
            switch (temp[i])
            {
                case '}':
                    if (chars.Count != 0)
                    {
                        if (chars.Pop() == '{')
                        {
                            check = true;
                        }
                        else
                        {
                            throw new Exception("is not correct");
                        }
                    }

                    break;
                case ']':
                    if (chars.Count != 0)
                    {
                        if (chars.Pop() == '[')
                        {
                            check = true;
                        }
                        else
                        {
                            throw new Exception("is not correct");
                        }
                    }
                    ;
                    break;
                case ')':
                    if (chars.Count != 0)
                    {
                        if (chars.Pop() == '(')
                        {
                            check = true;
                        }
                        else
                        {
                            throw new Exception("is not correct");
                        }
                    }
                    ;
                    break;
            }
        }
    }
}

if (check && chars.Count==0)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("false");
}
