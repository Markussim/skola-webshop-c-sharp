using System;
using System.Collections.Generic;
using System.Text;

namespace webshop
{
    class customer
    {
        private String _name;

        private List<product> productList = new List<product>();

        public customer(String inName)
        {
            _name = inName;
        }

        public String getName()
        {
            return _name;
        }

        public List<product> getProductsInCart()
        {
            return productList;
        }

        public void addProduct(product newProduct)
        {
            productList.Add(newProduct);
        }
    }
}
