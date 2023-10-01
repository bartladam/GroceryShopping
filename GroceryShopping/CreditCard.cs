using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class CreditCard
    {
        public string nameOwner { get; private set; }
        public string surnameOwner { get; private set; }
        public int moneyOnCard { get; set; }
        public CreditCard(string nameOwner, string surnameOwner, int moneyOnCard)
        {
            this.nameOwner = nameOwner;
            this.surnameOwner = surnameOwner;
            this.moneyOnCard = moneyOnCard;
        }
    }
}
