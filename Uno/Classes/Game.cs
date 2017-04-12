using System;
using System.Collections.Generic;
using Uno.Enums;

namespace Uno.Classes
{
    public class Game
    {
        public Guid GameId { get; }
        public GameDirection Direction { get; set; }
        public List<Player> Players { get; set; }
        public Deck Deck { get; set; }
        public List<Card> DiscardedPile { get; set; }
        public List<Card> ReservedPile { get; set; }

        public Game()
        {
            this.GameId = new Guid();
            this.Deck = new Deck();
            this.DiscardedPile = new List<Card>();
            this.ReservedPile = new List<Card>();
            this.Players = new List<Player>();
        }

        public override string ToString()
        {
            string game = string.Empty;

            game += "\nDirection of game is " + this.Direction.ToString() + "\n";

            game += "\nPlayers..\n";
            // Players 
            foreach (var player in this.Players)
            {
                game += player.ToString();
            }

            game += "\nDiscarded Pile..\n";
            foreach (var card in this.DiscardedPile)
            {
                game += card.ToString();
            }

            game += "\nReserved Pile..\n";
            foreach (var card in this.ReservedPile)
            {
                game += card.ToString();
            }

            return game;
        }

        public void StartGame()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.Direction = GameDirection.Clockwise;
            this.ReservedPile = this.Deck.Cards;
            for (int i = 0; i < 4; i++)
            {
                this.Players.Add(SetupPlayer("Player " + (i + 1)));
            }
            Card card = GetRandomCard();
            card.State = CardInState.Discarded;
            this.DiscardedPile.Add(card);
        }

        private Player SetupPlayer(string playerName)
        {
            Player player = new Player();
            player.Name = playerName;
            player.Hand = new Hand();
            player.Hand.Cards = new List<Card>();
            for (int i = 0; i < 7; i++)
            {
                Card card = GetRandomCard();
                card.State = CardInState.InHand;
                player.Hand.Cards.Add(card);
                this.ReservedPile.Remove(card);
            }

            return player;
        }

        private Card GetRandomCard()
        {
            Random rnd = new Random();
            int randomCount = this.Deck.Cards.Count - 1;
            int index = rnd.Next(0, randomCount);
            CardInState state = this.Deck.Cards[index].State;
            while (state == CardInState.InHand)
            {
                index = rnd.Next(0, randomCount);
                state = this.Deck.Cards[index].State;
            }
            return this.Deck.Cards[index];
        }
    }
}
