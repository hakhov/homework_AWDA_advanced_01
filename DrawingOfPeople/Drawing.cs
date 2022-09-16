using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingOfPeople
{
    public abstract class Drawing
    {
        private int marker { get; set; }
        private int pencil { get; set; }
        private int oilColor { get; set; }
        public string User;
        public int Marker
        {
            get { return marker; }
            set { marker = value < 0 ? -value : value; }
        }
        public int Pencil
        {
            get { return pencil; }
            set { pencil = value < 0 ? -value : value; }
        }
        public int OilColor
        {
            get { return oilColor; }
            set { oilColor = value < 0 ? -value : value ; }
        }
       
        public Drawing()
        {
            Marker = 1;
            Pencil = 1;
            OilColor = 1;
            User = null;
        }
        public Drawing(int x, string u)
        {
            Marker = x;
            User = u;
        }
        public Drawing(int x, int y,string u)
        {
            Marker = x;
            Pencil = y;
            User = u;
        }
        public Drawing(int x, int y, int z, string u)
        {
            Marker = x;
            Pencil = y;
            OilColor = z;
            User = u;
        }

        public abstract void DisplayQuantity();
        
        public abstract int Combination();
        
    }
}
