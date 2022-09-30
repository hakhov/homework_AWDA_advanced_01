using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewCarShop.Constants;

namespace NewCarShop
{
    public class Car
    {
        public  int ID { get; set; }
        public Make Make { get; set; }
        public string Name { get; set; }
        public  Color Color { get; set; }
        public int HP { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        
        public override string ToString ()
        {
            return $" ID is {ID}, Make is {Make.ToString() }, Name is {Name}, Color is {Color.ToString()}, Price is {Price} "; 
        }
    }

}
