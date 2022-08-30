using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class ClassKey
    {
        ConsoleKey key;
        public ClassKey(ConsoleKey key)
        { 
            this.key = key;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\tYou pressed: {key}\t The keyCode is: {(int)key}");
        }


    }
}
