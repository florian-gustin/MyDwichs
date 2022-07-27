using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Sandwich
    {
        public String Name { get; private set; }
        public List<Ingredient> IngredientList { get; private set; }
        public float Prices { get; private set; }

        public Sandwich(string name, List<Ingredient> ingredientList, float prices)
        {
            this.Name = name;
            IngredientList = ingredientList;
            this.Prices = prices;
        }
    }
}
