using System;
using System.Collections.Generic;
using Uno.Enums;

namespace Uno.Classes
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Initialize();
        }

        public void Initialize()
        {
            Cards = new List<Card>();

            for (int i = 0; i < Enum.GetValues(typeof(CardColour)).Length - 1; i++)
            {
                Cards.Add(new Card()
                {
                    Name = "0",
                    Type = CardType.Zero,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                for (int j = 1; j <= 9; j++)
                {
                    Cards.Add(new Card()
                    {
                        Name = j.ToString(),
                        Type = (CardType)j,
                        Colour = (CardColour)i,
                        State = CardInState.None
                    });
                    Cards.Add(new Card()
                    {
                        Name = j.ToString(),
                        Type = (CardType)j,
                        Colour = (CardColour)i,
                        State = CardInState.None
                    });
                }
                Cards.Add(new Card()
                {
                    Name = "Skip",
                    Type = CardType.Skip,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Reverse",
                    Type = CardType.Reverse,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Draw +2",
                    Type = CardType.Draw2,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Skip",
                    Type = CardType.Skip,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Reverse",
                    Type = CardType.Reverse,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Draw +2",
                    Type = CardType.Draw2,
                    Colour = (CardColour)i,
                    State = CardInState.None
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Cards.Add(new Card()
                {
                    Name = "Draw +4",
                    Type = CardType.Draw4,
                    Colour = CardColour.None,
                    State = CardInState.None
                });
                Cards.Add(new Card()
                {
                    Name = "Wild Card",
                    Type = CardType.WildCard,
                    Colour = CardColour.None,
                    State = CardInState.None
                });
            }
        }

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
