using Uno.Enums;

namespace Uno.Classes
{
    public class Card
    {
        public CardType Type { get; set; }
        public string Name { get; set; }
        public CardColour Colour { get; set; }
        public CardInState State { get; set; }

        public override string ToString()
        {
            return this.Colour + " '" + this.Name + "'\n";
        }
    }
}
