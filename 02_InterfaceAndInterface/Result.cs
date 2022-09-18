using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_InterfaceAndInterface
{
    internal class Result : IInterface1, IInterface2
    {
        public void Method()
        {
            Console.WriteLine("this is Method1 of IInterface1");
        }

        //ete sra demic public jnjenq error kta,kasi es classy chi implementacnum IInterface1-i methody,vorovhetev public keyword chenq karox ogtagorcel ystex
        //vonc vor paymanagir lini 1-in u 2-rd offisneri mijev
        //bayc paymanagri ketery arajin officin e hasaneli
        //chi kara urish 3-rd ofis dran hasaneliutyun unena

        //public void Method()
        //{
        //    Console.WriteLine("this is Method2 of IInterface2");
        //}
        //senc vor anenq kasi vor ays nuyn anunov u parametrerov method arden ka class-um senc ban chenq kara anenq
        //vorpes lucum arjarkum a ystex static grel,bayc ogut chi talis,meka asum a et anunov u parametrerov method arden ka classum

        void IInterface2.Method()
        {
            Console.WriteLine("this is Method2 of IInterface2");
        }
    }
}

//senc karanq mekiny grenq vor interface-ic a galis,myusiny che
//mekiny partadir piti grenq,te che 2 hat nuyn anunov u parametrerov method klini class
//u chi haskacvi vor methody vor interface-i implementacian e

