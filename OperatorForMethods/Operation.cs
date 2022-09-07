using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorForMethods
{
    public class Operation
    {
        public int a = 900;
        public int b = 310;

        public static Operation operator +(Operation ob1, Operation ob2)
        {
            Operation ob = new Operation();
            ob.a = ob1.a + ob2.b;
            return ob;
        }

        public static Operation operator -(Operation ob1, Operation ob2)
        {
            Operation ob = new Operation();
            ob.a = ob1.a - ob2.b;
            return ob;
        }

        public static Operation operator *(Operation ob1, Operation ob2)
        {
            Operation ob = new Operation();
            ob.a = ob1.a * ob2.b;
            return ob;
        }
        public static Operation operator /(Operation ob1, Operation ob2)
        {
            Operation ob = new Operation();
            ob.a = ob1.a / ob2.b;
            return ob;
        }

        public static Operation operator %(Operation ob1, Operation ob2)
        {
            Operation ob = new Operation();
            ob.a = ob1.a % ob2.b;
            return ob;
        }
    }
}