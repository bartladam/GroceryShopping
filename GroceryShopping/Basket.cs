using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class Basket
    {
        public List<Products> listProducts { get; private set; }
        public Basket()
        {
            listProducts = new List<Products>();
        }
        public void AddToBasket(Products product)
        {
            listProducts.Add(product);
        }
    }
}
