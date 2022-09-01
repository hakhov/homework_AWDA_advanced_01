using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Tuple_RefOut
{
    public class Solution
    {
        public double Solution1 { get; set; }
        public double Solution2 { get; set; }      

        public void Print()
        {
            Console.WriteLine("Solution without using tuple and out");
            Console.WriteLine($"Solution1: {Solution1} \tSolution2: {Solution2}");
        }
    }
}
