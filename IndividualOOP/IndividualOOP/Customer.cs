﻿namespace IndividualOOP
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer() { }

        public Customer(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
