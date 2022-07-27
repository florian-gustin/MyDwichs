using Domain;

namespace Application
{
    class OrderEngine
    {
        private readonly Dictionary<SandwichEnum, Sandwich> _board;

        public OrderEngine(Dictionary<SandwichEnum, Sandwich> board)
        {
            _board = board;
        }

        public Command ProcessOrder(String order)
        {
            Command command = new Command();
            command.AwaitOrder();
            List<String> items = order.Split(',').ToList();

            foreach (String item in items)
            {
                try
                {
                    SandwichEnum v = (SandwichEnum)Enum.Parse(typeof(SandwichEnum), item, true);
                    Sandwich sandwich1 = _board[v];
                    command.AddSandwich(sandwich1);
                }
                catch (Exception _)
                {
                    Console.WriteLine("Erreur lors de la commande, le sandwich specifié : "+ item + " n'existe pas");
                }
            }

            return command;
        }
    }
}


