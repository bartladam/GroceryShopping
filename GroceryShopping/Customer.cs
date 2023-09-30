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
        public void Shopping(Scan_Go scanGo)
        {
            if(scanGo is not null)
            {

            }
            else
            {

            }
        }
    }
}
