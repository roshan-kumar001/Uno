using System;

namespace Uno.Classes
{
    public class Player
    {
        public Guid PlayerId { get; }

        public string Name { get; set; }
        public Hand Hand { get; set; }

        public Player()
        {
            this.PlayerId = new Guid();
        }

        public override string ToString()
        {
            string player = string.Empty;

            player += "\n" + this.Name + "..\n";
            player += this.Hand.ToString();

            return player;
        }
    }
}
