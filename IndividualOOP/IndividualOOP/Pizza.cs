using System;

namespace IndividualOOP
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushrooms { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1}) [Cheese: {2}, Pepperoni: {3}, Mushrooms: {4}]",
                Name, Size, Cheese, Pepperoni, Mushrooms);
        }

        internal decimal GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
