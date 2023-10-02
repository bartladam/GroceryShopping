using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class CreditCard
    {
        /// <summary>
        /// Credit card have to name owner
        /// </summary>
        public string nameOwner { get; private set; }
        /// <summary>
        /// Credit card have to surname owner
        /// </summary>
        public string surnameOwner { get; private set; }
        /// <summary>
        /// If customer want to pay credit card, he has to some money on the credit card
        /// </summary>
        public int moneyOnCard { get; set; }
        public CreditCard(string nameOwner, string surnameOwner, int moneyOnCard)
        {
            this.nameOwner = nameOwner;
            this.surnameOwner = surnameOwner;
            this.moneyOnCard = moneyOnCard;
        }
    }
}
