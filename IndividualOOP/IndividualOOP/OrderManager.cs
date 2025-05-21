using System.Collections.Generic;

namespace IndividualOOP
{
    public class OrderManager
    {
        public List<Pizza> Pizzas { get; private set; }
        public List<Drink> Drinks { get; private set; }

        public OrderManager()
        {
            Pizzas = new List<Pizza>();
            Drinks = new List<Drink>();
        }

        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }

        public void AddDrink(Drink drink)
        {
            Drinks.Add(drink);
        }
    }
}
