using System;

namespace Domain
{
    public class Ingredient
    {
        public String Name { get; private set; }
        public String Quantity { get; private set; }

        public Ingredient(string name, string quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}
