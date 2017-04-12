using System.Collections.Generic;

namespace Uno.Classes
{
    public class Hand
    {
        public List<Card> Cards { get; set; }

        public override string ToString()
        {
            string cards = string.Empty;

            foreach (var card in Cards)
            {
                cards += card.ToString();
            }

            return cards;
        }
    }
}
