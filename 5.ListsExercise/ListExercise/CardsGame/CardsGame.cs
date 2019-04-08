using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> player1Cards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> player2Cards = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (Math.Min(player1Cards.Count, player2Cards.Count) > 0)
            {
                Play(player1Cards, player2Cards);
            }

            PrintWiner(player1Cards, player2Cards);

        }

        static void Play(List<int> player1Cards, List<int> player2Cards)
        {
            if(player1Cards[0] == player2Cards[0])
            {
                player1Cards.RemoveAt(0);
                player2Cards.RemoveAt(0);
                return;
            }

            if(player1Cards[0] > player2Cards[0])
            {
                player1Cards.Add(player1Cards[0]);
                player1Cards.Add(player2Cards[0]);
                player1Cards.RemoveAt(0);
                player2Cards.RemoveAt(0);
                return;
            }

            if (player2Cards[0] > player1Cards[0])
            {
                player2Cards.Add(player2Cards[0]);
                player2Cards.Add(player1Cards[0]);
                player1Cards.RemoveAt(0);
                player2Cards.RemoveAt(0);
                return;
            }
        }

        public static void PrintWiner(List<int> player1Cards, List<int> player2Cards)
        {
            if(player1Cards.Count > player2Cards.Count)
            {
                Console.WriteLine($"First player wins! Sum: {player1Cards.Sum()}");
                return;
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {player2Cards.Sum()}");
                return;
            }
        }
    }
}
