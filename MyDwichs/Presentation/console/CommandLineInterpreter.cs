
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Presentation.console
{
    public class CommandLineInterpreter : IInterpreter
    {
        private readonly Dictionary<SandwichEnum, Sandwich> BOARD;
        private readonly CommandLinePrinter commandLinePrinter;
        private readonly OrderEngine orderEngine;

        public CommandLineInterpreter(Dictionary<SandwichEnum, Sandwich> BOARD)
        {
            this.BOARD = BOARD;
            this.commandLinePrinter = new CommandLinePrinter();
            this.orderEngine = new OrderEngine(BOARD);
        }

        public void StartSession()
        {
            bool isFinished = false;

            this.Greetings();
            do
            {
                this.TakeOrder();
                isFinished = this.ShouldStopTakingOrder();
                Console.Clear();

            }
            while (!isFinished);

        }

        private void Greetings()
        {
            this.commandLinePrinter.message("Bienvenue a la sandwicherie !");
        }

        private void TakeOrder()
        {
            this.ShowMenu();

            this.commandLinePrinter.message("Que voulez-vous ?");
            String order = this.ReadUserInput();
            Command command = this.orderEngine.ProcessOrder(order);
            command.CompleteOrder();

            this.commandLinePrinter.message("Votre commande: " + order);
            InvoicePrinter.display(command, this.commandLinePrinter);
        }

        private void ShowMenu()
        {
            this.commandLinePrinter.message("Au menu: ");
            BoardPrinter.display(BOARD, this.commandLinePrinter);
        }

        private bool ShouldStopTakingOrder()
        {
            this.commandLinePrinter.message("Voulez-vous passer une nouvelle commande ? oui/non");
            String order = this.ReadUserInput();
            if (order == "oui")
            {
                return false;
            }
            return true;
        }

        private String ReadUserInput()
        {
            return Console.ReadLine();
        }
    }
}
