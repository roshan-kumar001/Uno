using System;
using Uno.Interfaces;

namespace Uno.Classes
{
    public class OutputOnFile : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine("ON FILE: {0}", message);
        }
    }
}
