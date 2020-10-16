using System;
using System.Collections.Generic;
using System.Text;

namespace webshop
{
    class Meat : product
    {
        public Meat(string name) : base(name)
        {
            //constructor(name);
        }

        public string getMeat()
        {
            return _name;
        }
    }
}
