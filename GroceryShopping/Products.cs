using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class Products
    {
        /// <summary>
        /// Used it for recognize product
        /// </summary>
        public string nameProduct { get; private set; }
        /// <summary>
        /// Unique number each product
        /// </summary>
        public int Barcode { get; private set; }
        /// <summary>
        /// Barcode is generated randomly
        /// </summary>
        private Random randomBarcode { get; set; }
        /// <summary>
        /// Customer have to know price product
        /// </summary>
        public int priceProduct { get; set; }
        public Products(string nameProduct)
        {
            this.nameProduct = nameProduct;
            randomBarcode = new Random();
            Barcode = randomBarcode.Next(1000000, 3000000);
        }
    }
}
