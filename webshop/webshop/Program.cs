using System;

namespace webshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            var firstCustomer = new customer(Console.ReadLine());

            //Console.WriteLine(firstCustomer.getName());

            

            while (true)
            {
                Console.WriteLine("Select an option: \n 1. Buy product \n 2. List bought products \n 3. Exit");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        string[] products = product.creatProductList().ToArray();
                        foreach (var product in products)
                        {
                            Console.WriteLine(product);
                        }
                        Console.WriteLine("Type one of the products to buy it");

                        while (true)
                        {
                            var productName = Console.ReadLine();
                            if (Array.IndexOf(products, productName) == -1)
                            {
                                Console.WriteLine("That product does not exist");
                            }
                            else
                            {
                                Console.WriteLine("Added product");
                                firstCustomer.addProduct(new product(productName));
                                break;
                            }
                            
                        }

                        break;

                    case 2:
                        foreach(var product in firstCustomer.getProductsInCart())
                        {
                            Console.WriteLine(product.getName());
                        }
                        break;

                    case 3:
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Invalid argument");
                        break;
                }
            }

        }
    }
}