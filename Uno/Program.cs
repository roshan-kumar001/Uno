using System;
using Uno.Simulator;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSimulator sim = new GameSimulator();
            sim.StartGame();

            Console.ReadLine();
        }
    }
}
