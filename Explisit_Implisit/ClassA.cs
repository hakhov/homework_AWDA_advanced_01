using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explisit_Implisit
{
    internal class ClassA
    {
        public double a;
        public double b;

        public ClassA(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public ClassA()
        {

        }

        public static ClassA operator +(ClassA classA, ClassA classB)
        {
            ClassA classA1 = new();
            classA1.a = classA.a + classB.a;
            classA1.b = classA.b + classB.b;
            return classA1;
        }
        public static ClassA operator -(ClassA classA, ClassA classB)
        {
            ClassA classA1 = new();
            classA1.a = classA.a - classB.a;
            classA1.b = classA.b - classB.b;
            return classA1;
        }
        public static ClassA operator *(ClassA classA, ClassA classB)
        {
            ClassA classA1 = new();
            classA1.a = classA.a * classB.a;
            classA1.b = classA.b * classB.b;
            return classA1;
        }
        public static ClassA operator /(ClassA classA, ClassA classB)
        {
            ClassA classA1 = new();
            classA1.a = classA.a / classB.a;
            classA1.b = classA.b / classB.b;
            return classA1;
        }

    }
}
