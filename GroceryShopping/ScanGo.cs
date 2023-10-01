using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class ScanGo
    {
        public Queue<Products> products { get; private set; }
        public GroceryCard groceryCard { get; set; }
        public ScanGo(GroceryCard groceryCard)
        {
            products = new Queue<Products>();
            this.groceryCard = groceryCard;
        }
        public void AddProductToList(Products product)
        {
            products.Enqueue(product);
        }

    }
}
