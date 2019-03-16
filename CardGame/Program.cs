using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        const int CARDS_COUNT = 36;
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количестов игроков: ");
            int playersCount = int.Parse(Console.ReadLine());
            Game gameManager = new Game(playersCount);
            for (int i = 0; i < playersCount; i++)
            {
                Console.WriteLine($"Игрок {i + 1}, введите свое имя: ");
                string name = Console.ReadLine();
                gameManager.Players[i].Name = name;
            }

            gameManager.Shuffle();
            gameManager.DealCards();

            int roundsCounter = 1;
            while (gameManager.CheckWin() == false)
            {
                Console.WriteLine("РАУНД " + roundsCounter);
                Console.WriteLine("Игроки кладут карты...\n");
                List<Card> currentCards = gameManager.PushCards();

                for (int i = 0; i < currentCards.Count(); i++)
                {
                    if (gameManager.Players[i].Cards.Count > 0)
                        Console.WriteLine($"{gameManager.Players[i].Name}  положил {currentCards[i].Suit} {currentCards[i].Type}\n");
                }

                Console.WriteLine($"{gameManager.Players[currentCards.IndexOf(currentCards.Max())].Name} выигрывает и забирает карты\n");
                currentCards.IndexOf(currentCards.Max());

                gameManager.Players[currentCards.IndexOf(currentCards.Max())].Cards.AddRange(currentCards);

                foreach (var player in gameManager.Players)
                    Console.WriteLine($"У {player.Name} {player.Cards.Count} карт");

                roundsCounter++;

                Console.ReadLine();
            }

            foreach (Player player in gameManager.Players)
            {
                if (player.Cards.Count == CARDS_COUNT)
                    Console.WriteLine($"{player.Name} победил!!! Спасибо за игру");
            }

            Console.ReadLine();
        }
    }
}
