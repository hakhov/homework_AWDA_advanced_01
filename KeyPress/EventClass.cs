using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPress
{
   public  class EventClass
    {
        public event Printing myEvent = null;
        public event Printing keyA= null;

        public void keyAInvoke()
        {
            if (keyA is not null)
            {
                keyA.Invoke();
            }
        }

        public void StartInvoke()
        {
            myEvent?.Invoke();
        }



    }
}
