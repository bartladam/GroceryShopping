using GroceryShopping;


Customer c = new Customer(new GroceryCard("Adam", "Bartl"));
c.Shopping(new ScanGo(c.groceryCard), new Basket(), new CreditCard("Adam", "Bartl", 320));

/*Customer c = new Customer(new GroceryCard("Adam", "Bartl"));
c.Shopping(null, new Basket(), new CreditCard("Adam", "Bartl", 50000));*/