﻿using System;

namespace MyConstAndGarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(ClassForConst.xx);
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(ClassForConst.xx);
            Console.WriteLine(ClassForConst.xxa);
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(ClassForConst.xx);
            Console.WriteLine(ClassForConst.xxa);
            Console.WriteLine(ClassForConst.xxb);
            Console.WriteLine(GC.GetTotalMemory(false));
            ClassReadOnly first = new();    
            Console.WriteLine(first.zz); 
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(first.zz); 
            Console.WriteLine(first.zza); 
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(first.zz);
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(4);
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(first.zza);
            Console.WriteLine(first.zzb);
            Console.WriteLine(GC.GetTotalMemory(false));
        }
    }
}
