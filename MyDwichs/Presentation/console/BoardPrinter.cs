using Design_pattern.entity;
using System.Collections.Generic;

namespace Design_pattern.ihm.console
{
    class BoardPrinter
    {

        public static void display(Dictionary<SandwichEnum, Sandwich> BOARD, CommandLinePrinter commandLinePrinter)
        {
            foreach(SandwichEnum sandwichEnum in BOARD.Keys)
            {
                Sandwich sandwich = BOARD[sandwichEnum];
                ShowSandwich(sandwichEnum, sandwich, commandLinePrinter);
                ShowIngredients(sandwich.IngredientList, commandLinePrinter);
            }
        }

        private static void ShowSandwich(SandwichEnum sandwichEnum, Sandwich sandwich, CommandLinePrinter commandLinePrinter)
        {
            commandLinePrinter.message(sandwichEnum.ToString() + ": " + sandwich.name);
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
