using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    /// <summary>
    /// Customer use basket even when he doens't use ScanGo
    /// </summary>
    internal class Basket
    {
        /// <summary>
        /// Product in basket
        /// </summary>
        public List<Products> listProducts { get; private set; }
        public Basket()
        {
            listProducts = new List<Products>();
        }
        /// <summary>
        /// Customer can something add to basket
        /// </summary>
        /// <param name="product"></param>
        public void AddToBasket(Products product)
        {
            listProducts.Add(product);
        }
    }
}
