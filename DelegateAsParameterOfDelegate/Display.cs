using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAsParameterOfDelegate
{
    
    public class Display
    {
        
        public void display(string txt)
        {
            Console.WriteLine(txt);
        }
        public void ForDelegateWithDelegate(string txt, DelegateVoid delegateVoid)
        {
           delegateVoid(txt);
        }
    }
    public delegate void DelegateWithDelegate(string txt, DelegateVoid delegateVoid);
    public delegate void DelegateVoid(string txt);
}
