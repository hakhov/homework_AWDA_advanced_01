using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkingWithRegEx
{
   public class RegEx
    {
        string pattern= @"[W|w][W|w][W|w]\.\w{1,}\.[C|c][o|O][m|M]";
        public void MatchingWithRegEx(string txt)
        {
            if (Regex.IsMatch(txt, pattern)) 
            {

                Console.WriteLine("Everything is correct");
            }
            else Console.WriteLine("try one more time");

            //MatchCollection match1 = Regex.Matches(txt, pattern);
            //foreach (Match item in match1)
            //{

            //    Console.WriteLine(item.Index );
            //    Console.WriteLine(item.Value );
            //    Console.WriteLine();
            //}
        }
    }
}
