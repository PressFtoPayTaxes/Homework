using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Game
    {
        public Player[] Players { get; set; }
        public List<Card> Cards { get; set; }
        const int CARDS_COUNT = 36;

        public Game(int playersCount)
        {
            if (playersCount < 2) playersCount = 2;
            else if (playersCount > 6) playersCount = 6;

            Players = new Player[playersCount];
            for (int i = 0; i < playersCount; i++)
            {
                Players[i] = new Player();
                Players[i].Cards = new List<Card>();
            }
            int cardTypesCount = 9;
            Cards = new List<Card>();
            for (int i = 0; i < cardTypesCount; i++)
            {
                Cards.Add(new Card { Suit = Suit.Spade, Type = (CardType)(i + 1) });
                Cards.Add(new Card { Suit = Suit.Heart, Type = (CardType)(i + 1) });
                Cards.Add(new Card { Suit = Suit.Club, Type = (CardType)(i + 1) });
                Cards.Add(new Card { Suit = Suit.Diamond, Type = (CardType)(i + 1) });
            }
        }

        public void Shuffle()
        {
            Random randomIndex = new Random();
            for (int i = 0; i < Cards.Count * 2; i++)
            {
                Card removedCard = Cards[0];
                Cards.RemoveAt(0);
                Cards.Insert(randomIndex.Next(Cards.Count), removedCard);
            }
        }

        public void DealCards()
        {
            int eachPlayersCardCount = Cards.Count / Players.Count();
            for (int i = 0; i < Players.Count(); i++)
            {
                for (int j = 0; j < eachPlayersCardCount; j++)
                {
                    Players[i].Cards.Add(Cards[j]);
                }
                Cards.RemoveRange(0, eachPlayersCardCount);
            }
        }

        public bool CheckWin()
        {
            foreach (Player player in Players)
            {
                if (player.Cards.Count == CARDS_COUNT)
                    return true;
            }
            return false;
        }

        public List<Card> PushCards()
        {
            List<Card> currentCards = new List<Card>();
            for (int i = 0; i < Players.Count(); i++)
            {
                if (Players[i].Cards.Count > 0)
                {
                    currentCards.Add(Players[i].Cards[0]);
                    Players[i].Cards.RemoveAt(0);
                }
                else
                    currentCards.Add(null);
            }

            return currentCards;
        }
    }
}
