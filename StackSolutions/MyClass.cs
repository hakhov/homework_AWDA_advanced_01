using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackSolutions
{
    class MyClass
    {
        private Stack myStack = new Stack();
        public void isCompleted(string str)
        {
            int straightBracket = 0;
            int curvedBracket = 0;
            int shapedBracket = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char sym = Convert.ToChar(str.Substring(i, 1));
                myStack.Push(sym);
                switch ((char)myStack.Pop())
                {
                    case '[':
                        straightBracket++;
                        break;
                    case '(':
                        curvedBracket++;
                        break;
                    case '{':
                        shapedBracket++;
                        break;
                    case ']':
                        straightBracket--;
                        break;
                    case ')':
                        curvedBracket--;
                        break;
                    case '}':
                        shapedBracket--;
                        break;
                    default:
                        break;

                }
               
            }
            if (shapedBracket == 0 && curvedBracket == 0 && straightBracket == 0)
                Console.WriteLine(true); 
            else
                Console.WriteLine(false); 


        }
    }
}
