
using System.Collections.Generic;
using Domain;
using Presentation;
using Presentation.console;

namespace MyDwichs
{
    public class Runner
    {
        public static Dictionary<SandwichEnum, Sandwich> BOARD = new Dictionary<SandwichEnum, Sandwich> {
            {
                SandwichEnum.Jb, SandwichFactory.CreateSandwich(SandwichEnum.Jb)
            },
            {
                SandwichEnum.Pc, SandwichFactory.CreateSandwich(SandwichEnum.Pc)
            }, 
            {                
                SandwichEnum.Dieppois, SandwichFactory.CreateSandwich(SandwichEnum.Dieppois)
            }
        };

        public static void Main(string[] args)
        {
            IInterpreter commandLineInterpretor = new CommandLineInterpreter(BOARD);
            commandLineInterpretor.StartSession();
        }
    }
}