using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Store
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public decimal Budget { get; set; }
        public Store()
        {

        }
        public Store(string name,string phone, string address, decimal budget)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Budget = budget;
        }

    }
}
