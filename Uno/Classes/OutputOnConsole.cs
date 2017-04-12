using System;
using Uno.Interfaces;

namespace Uno.Classes
{
    class OutputOnConsole : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
