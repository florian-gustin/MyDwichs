using System;
using System.Collections.Generic;
using System.Text;

namespace Presentation.console
{
    public class CommandLinePrinter : IPrinter
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
