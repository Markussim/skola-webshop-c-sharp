using System;

namespace webshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What's the customers name?");

            var firstCustomer = new customer("Markus");

            Console.WriteLine(firstCustomer.getName());

            //Console.WriteLine(product.getListOfProducts().ToString());

            /*for(int i = 0; i < 100; i++)
            {
                firstCustomer.addProduct(new product(i.ToString()));
            }*/

            

        }
    }
}