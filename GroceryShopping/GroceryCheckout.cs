using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class GroceryCheckout
    {
        public int priceProducts { get; set; }
        private bool choice { get; set; }
        public bool PaymentGate(ScanGo scanGo, Basket basket)
        {
            Console.Clear();
            if(scanGo is not null)
            {
                foreach (Products item in scanGo.products)
                {
                    Console.WriteLine("{0}, price: {1} Kč", item.nameProduct, item.priceProduct);
                    priceProducts += item.priceProduct;
                }
            }
            else
            {
                foreach (Products item in basket.listProducts)
                {
                    Console.WriteLine("{0}, price: {1} Kč", item.nameProduct, item.priceProduct);
                    priceProducts += item.priceProduct;
                }
            }
            Console.WriteLine("Summary price: {0} Kč", priceProducts);
            Console.WriteLine("\nCredit card payment [y/n]:");
            choice = (Console.ReadLine().Equals("y")) ? true : false;
            return choice;

        }
        public string Pay(CreditCard card)
        {
            if(card is not null)
            {
                card.moneyOnCard -= priceProducts;
                Console.WriteLine(card.moneyOnCard);
            }
            else
            {
                while (priceProducts > 0)
                {
                    Console.WriteLine("Entry money: ");
                    int money = int.Parse(Console.ReadLine());
                    priceProducts -= money;
                }
            }
            return string.Format("Paid sucessfully");
        }
    }
}
