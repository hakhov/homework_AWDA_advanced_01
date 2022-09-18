using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InterfaceAndInterface
{
    internal class Result : IInterface1, IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("this is Method of IInterface1");
        }
        //implementation of IInterface1 explicitly

        void IInterface2.Method()
        {
            Console.WriteLine("this is Method of IInterface2");
        }
    }
}

//es dzevov iraric anjatvum enq te vor methody vor interface-ic e galis

//es 2 methodi koxnqn el public chenq karox grel,asum a public keyword valid chi ays itemi hamar
