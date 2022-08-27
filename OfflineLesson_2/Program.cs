using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfflineLesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the opertaion /add , sub , mul , div/");
            string operation = Console.ReadLine().ToLower();
            int op = (int)Enum.Parse(typeof(MathOperation), operation);
            DoOperation(number1, number2, (MathOperation)op);
        }
        public enum MathOperation
        {
            add,
            sub,
            mul,
            div
        }
        public static void DoOperation(int a,int b, MathOperation operation)
        {
            int result = 0;
            switch (operation)
            {
                case MathOperation.add:
                    result = a + b;
                    break;
                case MathOperation.sub:
                    result = a - b;
                    break;
                case MathOperation.mul:
                    result = a * b;
                    break;
                case MathOperation.div:
                    result = a - b;
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
