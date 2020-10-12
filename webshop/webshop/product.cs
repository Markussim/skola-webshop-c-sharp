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
            if(creatProductList().Contains(name))
            {
                _name = name;
            } else
            {
                throw new System.ArgumentException("That product does not exist", "original");
            }
        }

        public static List<string> creatProductList()
        {
            List<string> theList = new List<string>();

            theList.Add("Nudlar");

            theList.Add("Grönsak");

            theList.Add("Kött");

            return theList;
        }
    }
}
