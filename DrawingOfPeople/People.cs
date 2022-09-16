using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace DrawingOfPeople
{
    public class People : Drawing
    {
        public override int Combination()
        {
            
                int x = Marker * Pencil + Marker * OilColor + OilColor * Pencil;
                Console.WriteLine($"I have two hands so i can draw in {x} ways");
                return x;
                                 
        }

        public override void DisplayQuantity()
        {
            
                Console.WriteLine($"I am {User} and I have {Marker} markers, {Pencil} pencils and {OilColor} oilcolors!!!");
            
        }

        public People()
        {

        }
      
        public People(int x, int y, string u) : base(x,u)
        {
            this.OilColor = y;
        }
         
    }
}
