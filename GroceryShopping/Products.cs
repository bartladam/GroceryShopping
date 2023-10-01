using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class Products
    {
        public string nameProduct { get; private set; }
        public int Barcode { get; private set; }
        private Random randomBarcode { get; set; }
        public int priceProduct { get; set; }
        public Products(string nameProduct)
        {
            this.nameProduct = nameProduct;
            randomBarcode = new Random();
            Barcode = randomBarcode.Next(1000000, 3000000);
        }
    }
}
