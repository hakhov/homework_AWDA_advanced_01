using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Compare
{
    public class StringCompare
    {
        public void CompareString(string first,string second)
        {
            if(first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] > second[i])
                    {
                        Console.WriteLine("First string is bigger");
                        break;
                    }
                    else if (first[i]<second[i])
                    {
                        Console.WriteLine("Second string is bigger");
                        break;
                    }
                }
            }
            else if(first.Length < second.Length)
            {
                Console.WriteLine("Second string is bigger");
            }
            else
            {
                Console.WriteLine("First string is bigger");
            }
        }
    }
}
