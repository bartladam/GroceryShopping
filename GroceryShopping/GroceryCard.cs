using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopping
{
    internal class GroceryCard
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int numberCard { get; private set; }
        private Random randomNumber { get; set; }
        public int bonusPoints { get; private set; } // i have to complete it
        public GroceryCard(string name, string surname)
        {
            randomNumber = new Random();
            this.Name = name;
            this.Surname = surname;
            this.numberCard = randomNumber.Next(1000000, 3000000);
        }

    }
}
