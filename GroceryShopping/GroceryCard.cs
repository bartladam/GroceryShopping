using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class GroceryCard
    {
        /// <summary>
        /// Grocery card have to name, for recognize customer
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Grocery card have to surname, for recognize customer
        /// </summary>
        public string Surname { get; private set; }
        /// <summary>
        /// Specific number, which is used when we use ScanGo
        /// </summary>
        public int cardNumber { get; private set; }
        /// <summary>
        /// Card number is setted randomly
        /// </summary>
        private Random randomNumber { get; set; }
        /// <summary>
        /// When customer own this card, he can collect bonus points from shopping
        /// </summary>
        public int bonusPoints { get; set; }
        public GroceryCard(string name, string surname)
        {
            randomNumber = new Random();
            this.Name = name;
            this.Surname = surname;
            this.cardNumber = randomNumber.Next(1000000, 3000000);
        }

    }
}
