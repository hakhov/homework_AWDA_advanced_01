using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InterfaceAndInterface
{
    internal class Result : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("this is Method1 of IInterface1");
        }



    }
}

//qani vor 2 um el ka nuyn anunov methody,uremn meki hamar implementacnenq,avtomat khashvi vor 2 i hamar el arel enq

//If Method() is declared in the Dual class, it will be used by both interfaces as the implementation

