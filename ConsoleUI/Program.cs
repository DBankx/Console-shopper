using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommerceLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuSelect = -1;

            CustomerModel customer = new CustomerModel();

            var products = CreateProduct();

            while(menuSelect != 6)
            {
                Console.WriteLine("Welcome to console Shopper \n MENU OPTIONS--------------- \n press 1 to create Profile \n press 2 to view profile \n press 3 for viewing all products in the store \n press 4 to add a product to your cart \n press 5 to checkout your cart \n press 6 to exit console shopper");
                Console.WriteLine("What do you want to do? ");
                menuSelect = Convert.ToInt32(Console.ReadLine());

                if(menuSelect == 6)
                {
                    Console.WriteLine("Thank you for shopping with console... bye");
                }
                if (menuSelect == 1)
                {
                    Console.Write("What is your full name? ");
                    customer.FullName = Console.ReadLine();
                    Console.Write("What is your phone number? ");
                    customer.PhoneNumber = Console.ReadLine();
                    Console.Write("What is your email? ");
                    customer.Email = Console.ReadLine();
                    Console.Write("What is your city? ");
                    customer.City = Console.ReadLine();

                    Console.WriteLine("Your account has been created start shopping....");
                }
                else if (menuSelect == 2)
                {
                    customer.GetCustomer();
                }
                else if (menuSelect == 3)
                {
                    foreach(var product in products)
                    {
                        Console.WriteLine($"Title: {product.Title}, price: ${product.price}");
                    }
                } else if (menuSelect == 4)
                {
                    Console.WriteLine("All the items have been placed in your cart");

                } else if (menuSelect == 5)
                {
                    foreach(var product in products)
                    {
                        product.DispatchItem(customer);

                        if(product is DigitalProductModel digital)
                        {
                            Console.WriteLine($"please check your email for ${digital.Title}");
                        }
                    }
                } else
                {
                    Console.WriteLine("Please select a valid menu option");
                }


            }

            Console.ReadKey();
        }


        //creating a list of products
        private static List<IProductModel> CreateProduct()
        {
            var output = new List<IProductModel> {
                 new DigitalProductModel {Title = "Spicy codes", price= 2},
            new ProductModel {Title = "Plate set", price=20},
            new ProductModel {Title = "Pokemon Shirt", price=9},
            new ProductModel {Title = "Hublot watch", price=50},
            new ProductModel {Title = "Speakers", price=120},
            new ProductModel {Title = "Beats Headphones", price=1120},
            new DigitalProductModel {Title = "COD modern warfare codes", price= 2}
            };

            return output;
        }
    }
}
