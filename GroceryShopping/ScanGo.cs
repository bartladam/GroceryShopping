using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    /// <summary>
    /// Customer can use ScanGo for faster shopping
    /// </summary>
    internal class ScanGo
    {
        /// <summary>
        /// Scanned and saved product in device ScanGo
        /// </summary>
        public Queue<Products> products { get; private set; }
        /// <summary>
        /// We can't use ScanGo without grocery card
        /// </summary>
        public GroceryCard groceryCard { get; set; }
        public ScanGo(GroceryCard groceryCard)
        {
            products = new Queue<Products>();
            this.groceryCard = groceryCard;
        }
        /// <summary>
        /// Customer scan product and system add this product to list
        /// </summary>
        /// <param name="product"></param>
        public void AddProductToList(Products product)
        {
            products.Enqueue(product);
        }

    }
}
