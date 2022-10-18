using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWithClassAndInterface
{
    class Human : StandardClass, IEat
    {
         void IEat.EatingProcess()
        {
            Console.WriteLine("Eating from Interface");
        }

        //public override void EatingProcess()
        //{
        //    Console.WriteLine("Eating from Inherited Method");
        //}
        public override void Eating()
        {
            base.Eating();
        }


    }
}
