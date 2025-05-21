using System.Collections.Generic;

namespace IndividualOOP
{
    public class OrderManager
    {
        private List<Order> orders;

        public OrderManager()
        {
            orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }
    }
}
