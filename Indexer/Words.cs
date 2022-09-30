using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
   public class Words
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public Words(string source, string destination) 
        {
            Source = source;
            Destination = destination;
        }
        
    }
}
