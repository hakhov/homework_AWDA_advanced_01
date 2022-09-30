
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class TransProc
    {
        public Words[] Arr = new Words[3];
        public string this[string source ]
        {
            get 
            {
                Words obj = null;
                foreach (var word in Arr)
                {
                    if (word.Source==source)
                    {
                        obj = word;
                        break;
                    }
                }
                return obj?.Destination;
            }
            set 
            {
                foreach (var word in Arr)
                {
                    if (source==word.Source)
                    {
                        word.Source = value;
                        break;
                    }
                }
            
            }
        }
    }
}
