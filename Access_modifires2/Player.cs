using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Access_modifires2
{
    public class Player:Human
    {
        public string Sport { get; set; }

        public Player(string name,int age,int id,string sport):base(name, age, id)
        {
            Sport = sport;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Sport: {Sport}");
        }
    }
}
