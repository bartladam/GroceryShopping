using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class Customer
    {
        public GroceryCard groceryCard { get; init; }
        public Customer(GroceryCard? card)
        {
            this.groceryCard = card;
        }
        public void Shopping(ScanGo scanGo, Basket basket, CreditCard card)
        {
            string choice;
            if (scanGo is not null)
            {
                do
                {
                    Console.WriteLine("Do you want add next product [y/n]:");
                    choice = Console.ReadLine();
                    if(choice.Equals("y"))
                    {
                        Console.Clear();
                        Console.Write("Product: ");
                        Products product = new Products(Console.ReadLine()) { priceProduct = 120};
                        Console.WriteLine("Product scaned by ScanGo");
                        scanGo.AddProductToList(product);
                        basket.AddToBasket(product);
                    }
                    else
                    {
                        GroceryCheckout checkout = new GroceryCheckout();
                        if (checkout.PaymentGate(scanGo, basket))
                            Console.WriteLine(checkout.Pay(card)); 
                        else
                            Console.WriteLine(checkout.Pay(null)); 

                    }
                } while (choice != "n");
            }
            else
            {
                do
                {
                    Console.WriteLine("Do you want add next product [y/n]:");
                    choice = Console.ReadLine();
                    if (choice.Equals("y"))
                    {
                        Console.Clear();
                        Console.Write("Product: ");
                        Products product = new Products(Console.ReadLine()) { priceProduct = 120 };
                        basket.AddToBasket(product);
                    }
                    else
                    {
                        GroceryCheckout checkout = new GroceryCheckout();
                        if (checkout.PaymentGate(scanGo, basket))
                            Console.WriteLine(checkout.Pay(card)); 
                        else
                            Console.WriteLine(checkout.Pay(null));

                    }
                } while (choice != "n");
            }
        }
    }
}
