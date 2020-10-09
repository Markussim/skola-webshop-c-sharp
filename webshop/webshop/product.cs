using System;
using System.Collections.Generic;
using System.Text;

namespace webshop
{
    class product
    {

        private string _name;

        public string getName()
        {
            return _name;
        }

        public product(string name)
        {
            _name = name;
        }
    }
}
