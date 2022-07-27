using Design_pattern.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_pattern.ihm.console
{
    class InvoicePrinter
    {
        public static void display(Command command, CommandLinePrinter commandLinePrinter)
        {
            float totalPrice = 0;
            commandLinePrinter.message("Resume de votre commande: ");

            foreach(Sandwich sandwich in command.SandwichList)
            {
                totalPrice += sandwich.prices;
                commandLinePrinter.message(sandwich.name);

                ShowIngredients(sandwich.IngredientList, commandLinePrinter);
            }

            commandLinePrinter.message("Prix total: " + totalPrice + "€");
        }

        private static void ShowIngredients(List<Ingredient> ingredients, CommandLinePrinter commandLinePrinter)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                commandLinePrinter.message("    " + ingredient.Name);
            }
        }
    }
}
