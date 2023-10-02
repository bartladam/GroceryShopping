using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    /// <summary>
    /// Guides the customer in payment in grocery 
    /// </summary>
    internal class GroceryCheckout
    {
        /// <summary>
        /// Summary price for all products in basket
        /// </summary>
        public int priceProducts { get; set; }
        /// <summary>
        /// Choice "true" is signalization, that customer want to pay credit card
        /// </summary>
        private bool choice { get; set; }
        /// <summary>
        /// If customer used ScanGo, he has easier process in payment
        /// </summary>
        private ScanGo scanGo { get; set; }
        /// <summary>
        /// Summarize all things in basket or in ScanGO
        /// </summary>
        /// <param name="scanGo"></param>
        /// <param name="basket"></param>
        /// <returns></returns>
        public bool PaymentGate(ScanGo scanGo, Basket basket)
        {
            this.scanGo = scanGo;
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
            Console.WriteLine("-----------------");
            Console.WriteLine("Summary price: {0} Kč", priceProducts);
            Console.WriteLine("\nCredit card payment [y/n]:");
            choice = (Console.ReadLine().Equals("y")) ? true : false;
            return choice;

        }
        /// <summary>
        /// After summarization basket or ScanGo and checked by customer, the customer has to pay it
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public string Pay(CreditCard card)
        {
            int temp = priceProducts;
            if(card is not null && card.moneyOnCard >= priceProducts)
            {
                card.moneyOnCard -= priceProducts;
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
            scanGo.groceryCard.bonusPoints += temp / 100;
            Console.WriteLine("You have got {0} bonus points on your card", scanGo.groceryCard.bonusPoints);
            return string.Format("Paid sucessfully.");
        }
    }
}
