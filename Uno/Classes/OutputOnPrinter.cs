using Uno.Interfaces;
using System;

namespace Uno.Classes
{
    class OutputOnPrinter : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine("ON PRINTER: {0}", message);
        }
    }
}
