
namespace Domain
{
    internal abstract class SandwichFactory
    {
        public static Sandwich CreateSandwich(SandwichEnum sandwichEnum)
        {
            if (sandwichEnum == SandwichEnum.Jb)
            {
                return CreateJbSandwich();
            }
            else if (sandwichEnum == SandwichEnum.Pc)
            {
                return CreatePcSandwich();
            }
            else if (sandwichEnum == SandwichEnum.Dieppois)
            {
                return CreateDieppoisSandwich();
            }
            else
            {
                throw new ArgumentException("Sandwich enum: " + sandwichEnum + ", is not recognized.");
            }
        }

        private static Sandwich CreateJbSandwich()
        {
            return new Sandwich("Jambon beurre", new List<Ingredient> {
                    Cook.GetInstance().Pain,
                    Cook.GetInstance().Jambon,
                    Cook.GetInstance().Beurre
                }, 3.5f);
        }

        private static Sandwich CreatePcSandwich()
        {
            return new Sandwich("Poulet crudités", new List<Ingredient> {
                    Cook.GetInstance().Pain,
                    Cook.GetInstance().Oeuf,
                    Cook.GetInstance().Tomate,
                    Cook.GetInstance().Poulet,
                    Cook.GetInstance().Mayonnaise,
                    Cook.GetInstance().Salade,
                }, 5.00f);
        }

        private static Sandwich CreateDieppoisSandwich()
        {
            return new Sandwich("Dieppois", new List<Ingredient> {
                    Cook.GetInstance().Pain,
                    Cook.GetInstance().Thon,
                    Cook.GetInstance().Tomate,
                    Cook.GetInstance().Mayonnaise,
                    Cook.GetInstance().Salade,
                }, 4.5f);
        }
    }
}
