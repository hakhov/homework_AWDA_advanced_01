﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndClass
{
    internal class Result : ClassA, IInterface1, IInterface2
    {
        //public void Method()
        //{
        //    Console.WriteLine("this is Method of Class");
        //}

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
//senc tarberak el kara lini,vor 2 interfaceneri implementacian tvel enq
//plyus classn el ira methody uni
