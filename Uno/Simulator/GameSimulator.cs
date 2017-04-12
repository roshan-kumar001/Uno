using Uno.Classes;
using Uno.Interfaces;

namespace Uno.Simulator
{
    public class GameSimulator
    {
        IOutput output;

        public GameSimulator()
        {
            output = new OutputOnConsole();
        }

        public void StartGame()
        {
            //Deck deck = new Deck();
            Game game = new Game();
            game.StartGame();

            output.Print(game.ToString());
        }
    }
}
