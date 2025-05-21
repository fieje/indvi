using System;
using System.Collections.Generic;

namespace IndividualOOP
{
    public class Order
    {
        public Customer Customer { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<string> Drinks { get; set; }

        public DateTime OrderTime { get; set; }

        public Order()
        {
            Pizzas = new List<Pizza>();
            Drinks = new List<string>();
            OrderTime = DateTime.Now;
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;

            for (int i = 0; i < Pizzas.Count; i++)
            {
                total += Pizzas[i].GetPrice();
            }

            total += Drinks.Count * 30; // Напої по 30 грн
            return total;
        }

        public override string ToString()
        {
            return "Замовлення для: " + Customer.Name + ", Сума: " + GetTotalPrice() + " грн";
        }
    }
}
